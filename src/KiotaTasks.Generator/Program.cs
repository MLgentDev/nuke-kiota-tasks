// See https://aka.ms/new-console-template for more information

using System.CommandLine;
using System.CommandLine.Binding;
using kiota;
using Nuke.CodeGeneration;
using Nuke.CodeGeneration.Model;
using Nuke.Common.Utilities;
using Task = Nuke.CodeGeneration.Model.Task;

var rootCommand = KiotaHost.GetRootCommand();
var tool = ConvertCommandToTool(rootCommand);
var toolFile = Path.GetFullPath("Kiota.json");
ToolSerializer.Save(tool, toolFile);
// Console.WriteLine(File.ReadAllText(toolFile));

return;


Tool ConvertCommandToTool(Command command)
{
    var commandToTool = new Tool();
    commandToTool.Name = "Kiota";
    commandToTool.OfficialUrl = "https://github.com/microsoft/kiota";
    commandToTool.PathExecutable = "kiota";
    commandToTool.References = ["https://learn.microsoft.com/en-us/openapi/kiota/using"];
    commandToTool.Help = "OpenAPI based HTTP Client code generator";

    var tasks = GetTasks(command, root: true);
    commandToTool.Tasks.AddRange(tasks);
    
    var enumsDescriptors = GetToolTypeDescriptors().Values.Where(x => x.IsEnum).Distinct();
    foreach (var enumsDescriptor in enumsDescriptors)
    {
        var enumeration = new Enumeration();
        enumeration.Name = enumsDescriptor.OptionEnumName;
        enumeration.Values = enumsDescriptor.OptionEnumValues!.ToList();
        commandToTool.Enumerations.Add(enumeration);
    }
    
    return commandToTool;
}

Task[] GetTasks(Command command, string postfix = "", string definiteArgument = "", bool root = false)
{
    var tasks = new List<Task>();

    if (command.Subcommands.Any())
    {
        foreach (var subCommand in command.Subcommands)
        {
            var subCommandTasks = GetTasks(subCommand,
                root ? postfix : $"{postfix}{command.Name.Capitalize()}".Trim(),
                root ? definiteArgument : $"{definiteArgument} {command.Name}".Trim());
            tasks.AddRange(subCommandTasks);
        }
    }
    else
    {
        var task = GetTask(command, postfix, definiteArgument);
        tasks.Add(task);
    }

    return tasks.ToArray();
}

Task GetTask(Command subCommand, string postfix = "", string definiteArgument = "")
{
    var task = new Task();
    task.Help = subCommand.Description;
    task.Postfix = !string.IsNullOrEmpty(postfix)
        ? $"{postfix}{subCommand.Name.Capitalize()}"
        : subCommand.Name.Capitalize();
    task.DefiniteArgument = !string.IsNullOrEmpty(definiteArgument)
        ? $"{definiteArgument} {subCommand.Name}".Trim()
        : subCommand.Name;
    task.SettingsClass = new SettingsClass();
    var argumentPostion = 0;
    foreach (var argument in subCommand.Arguments)
    {
        var property = GetArgumentProperty(argument, argumentPostion);

        task.SettingsClass.Properties.Add(property);
        argumentPostion++;
    }

    foreach (var option in subCommand.Options)
    {
        var property = GetOptionProperty(option);

        task.SettingsClass.Properties.Add(property);
    }

    return task;
}

Property GetArgumentProperty(Argument argument, int position)
{
    var toolTypeDescriptor = GetToolTypeDescriptor(argument.ValueType);
    var property = new Property();
    property.Name = GenerateName(argument.Name);
    property.Type = toolTypeDescriptor.OptionType;
    property.Format = "{value}";
    property.Help = argument.Description;
    property.Position = position;
    if (argument.HasDefaultValue)
    {
        property.Default = argument.GetDefaultValue()?.ToString();
    }

    return property;
}

Property GetOptionProperty(Option option1)
{
    {
        var toolTypeDescriptor = GetToolTypeDescriptor(option1.ValueType);
        var property1 = new Property();
        property1.Name = GenerateName(option1.Name);
        property1.Type = toolTypeDescriptor.OptionType;
        property1.Format = option1.Arity.MaximumNumberOfValues >= 1 
            ? $"{ExtractBestAlias(option1)} {{value}}"
            : $"{ExtractBestAlias(option1)}";

        if (option1.Arity.MaximumNumberOfValues > 1 && toolTypeDescriptor.IsCollection)
        {
            property1.Separator = " ";
        }

        property1.Help = option1.Description;
        if (((IValueDescriptor) option1).HasDefaultValue && option1.Arity.MaximumNumberOfValues == 1)
        {
            property1.Default = ((IValueDescriptor) option1).GetDefaultValue()?.ToString();
        }

        property1.Secret = option1.Name == "pat";

        return property1;
    }

    string? ExtractBestAlias(Option option)
    {
        return option.Aliases?.FirstOrDefault();
    }
}

string GenerateName(string name)
{
    return string.Join("", name.Split("-").Select(x => x.Capitalize()));
}

ToolTypeDescriptor GetToolTypeDescriptor(Type commandType)
{
    return GetToolTypeDescriptors().TryGetValue(commandType, out var descriptor)
        ? descriptor
        : throw new NotSupportedException($"The command type {commandType} is not supported.");
}

Dictionary<Type, ToolTypeDescriptor> GetToolTypeDescriptors()
{
    var dict = new Dictionary<Type, ToolTypeDescriptor>();

    dict[typeof(string)] = new ToolTypeDescriptor()
    {
        OptionType = "string",
    };
    dict[typeof(List<string>)] = new ToolTypeDescriptor()
    {
        OptionType = "List<string>",
        IsCollection = true
    };
    dict[typeof(bool)] = new ToolTypeDescriptor()
    {
        OptionType = "bool",
    };
    dict[typeof(uint)] = new ToolTypeDescriptor()
    {
        OptionType = "int",
    };
    var langDescriptor = new ToolTypeDescriptor()
    {
        // OptionType = "string",
        OptionType = "GenerationLanguage",
        OptionEnumName = "GenerationLanguage",
        OptionEnumValues = Enum.GetValues<Kiota.Builder.GenerationLanguage>()
            .Select(x => x.ToString())
            .ToArray()
    };
    dict[typeof(Kiota.Builder.GenerationLanguage)] = langDescriptor;
    dict[typeof(Kiota.Builder.GenerationLanguage?)] = langDescriptor;
    dict[typeof(Kiota.Builder.CodeDOM.AccessModifier)] = new ToolTypeDescriptor()
    {
        // OptionType = "string",
        OptionType = "AccessModifier",
        OptionEnumName = "AccessModifier",
        OptionEnumValues = Enum.GetValues<Kiota.Builder.CodeDOM.AccessModifier>()
            .Select(x => x.ToString())
            .ToArray()
    };
    dict[typeof(Microsoft.Extensions.Logging.LogLevel)] = new ToolTypeDescriptor()
    {
        // OptionType = "string",
        OptionType = "LogLevel",
        OptionEnumName = "LogLevel",
        OptionEnumValues = Enum.GetValues<Microsoft.Extensions.Logging.LogLevel>()
            .Select(x => x.ToString())
            .ToArray()
    };
    dict[typeof(Kiota.Builder.DependencyType[])] = new ToolTypeDescriptor()
    {
        // OptionType = "List<string>",
        OptionType = "List<DependencyType>",
        IsCollection = true,
        OptionEnumName = "DependencyType",
        OptionEnumValues = Enum.GetValues<Kiota.Builder.DependencyType>()
            .Select(x => x.ToString())
            .ToArray()
    };
    dict[typeof(kiota.Rpc.RpcMode)] = new ToolTypeDescriptor()
    {
        // OptionType = "string",
        OptionType = "RpcMode",
        OptionEnumName = "RpcMode",
        OptionEnumValues = Enum.GetValues<kiota.Rpc.RpcMode>()
            .Select(x => x.ToString())
            .ToArray()
    };

    return dict;
}


class ToolTypeDescriptor
{
    public required string OptionType { get; set; }
    public bool IsCollection { get; set; }
    public bool IsEnum => !string.IsNullOrEmpty(OptionEnumName) && OptionEnumValues?.Length > 0;
    public string? OptionEnumName { get; set; }
    public string[]? OptionEnumValues { get; set; }
}