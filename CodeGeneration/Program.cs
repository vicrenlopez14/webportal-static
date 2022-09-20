using System.IO;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.OperationNameGenerators;

namespace CodeGeneration
{
    public static class Program
    {
        public static void Main()
        {
            var document = OpenApiDocument.FromUrlAsync("https://localhost:7073/swagger/v1/swagger.json").Result;

            var generatorSettings = new CSharpClientGeneratorSettings();
            generatorSettings.CSharpGeneratorSettings.Namespace = "ProFind.Lib.Global.Services";
            generatorSettings.ClassName = "WebServiceClient";
            generatorSettings.CSharpGeneratorSettings.RequiredPropertiesMustBeDefined = false;
            generatorSettings.CSharpGeneratorSettings.ExcludedTypeNames = new[] { "JsonInheritanceConverter" };
            // Allow nulls
            generatorSettings.CSharpGeneratorSettings.GenerateNullableReferenceTypes = false;
            generatorSettings.CSharpGeneratorSettings.GenerateOptionalPropertiesAsNullable = true;
            generatorSettings.CSharpGeneratorSettings.ArrayType = "System.Collections.Generic.List";
            generatorSettings.CSharpGeneratorSettings.ArrayInstanceType = "System.Collections.Generic.List";
            generatorSettings.CSharpGeneratorSettings.ArrayBaseType = "System.Collections.Generic.List";
            generatorSettings.CSharpGeneratorSettings.DictionaryBaseType = "System.Collections.Generic.Dictionary";
            generatorSettings.CSharpGeneratorSettings.DictionaryInstanceType = "System.Collections.Generic.Dictionary";
            generatorSettings.CSharpGeneratorSettings.DictionaryType = "System.Collections.Generic.Dictionary";
            generatorSettings.GenerateOptionalParameters = true;
            generatorSettings.GenerateClientInterfaces = true;
            generatorSettings.ExceptionClass = "ProFindServicesException";
            // Set operation generation mode to SingleClientFromOperationId
            generatorSettings.OperationNameGenerator = new SingleClientFromOperationIdOperationNameGenerator();
            // generatorSettings.OperationNameGenerator = new TagNameGenerator();
            generatorSettings.UseBaseUrl = false;

            var codeGenerator = new CSharpClientGenerator(document, generatorSettings);

            var code = codeGenerator.GenerateFile();

            code = code.Replace(" = new FieldPropertiesDto();", string.Empty);
            code = code.Replace(" = new RuleTriggerDto();", string.Empty);
            code = code.Replace(" = new RuleAction();", string.Empty);
            code = code.Replace("Newtonsoft.Json.Required.DisallowNull", "Newtonsoft.Json.Required.Default");
            code = code.Replace(
                "new System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.Collection<CallsUsagePerDateDto>>();",
                "new System.Collections.Generic.Dictionary<string, System.Collections.Generic.ICollection<CallsUsagePerDateDto>>();");
            code = code.Replace("public FieldNames", "public System.Collections.Generic.ICollection<string>");

            File.WriteAllText(@"..\..\..\..\ProFind\Lib\Global\Services\Generated.cs", code);
        }

        public sealed class TagNameGenerator : MultipleClientsFromOperationIdOperationNameGenerator
        {
            public override string GetClientName(OpenApiDocument document, string path, string httpMethod,
                OpenApiOperation operation)
            {
                if (operation.Tags?.Count == 1)
                {
                    return operation.Tags[0];
                }

                return base.GetClientName(document, path, httpMethod, operation);
            }
        }
    }
}