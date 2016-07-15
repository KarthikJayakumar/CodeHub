using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.IO; 

namespace GsfRulesValidator
{
    public class SourceCodeGenerator
    {
        private string _code = string.Empty;
        private string _methodImplementaion = string.Empty;
        private string _className = string.Empty;

        public string ClassName
        {
            set { _className = value; }
            get { return _className; }
        }
        public string MethodImplementaion
        {
            set { _methodImplementaion = value; }
            get { return _methodImplementaion; }
        }
        public string Code
        {
            get { return _code; }
        }
        public string ParameterType { get; set; }
        public string ParameterName { get; set; }
        public string ReturnType { get; set; }
        public SourceCodeGenerator()
        {
            // TODO: Complete member initialization
        }
        public string GenerateSourceCode()
        {
            ConstructClass();
            return _code;
        }
        private void ConstructClass()
        {
            #region Unit
            CodeCompileUnit unit = new CodeCompileUnit();
            //CodeAttributeArgument[] arguments = new CodeAttributeArgument[2];
            //arguments[0] = new CodeAttributeArgument(new CodePrimitiveExpression(this.GetType().Assembly.FullName));//Create parameter for attribute
            //arguments[1] = new CodeAttributeArgument(new CodeSnippetExpression("DynamicCodeGeneration.CustomAttributes.GenerationMode.CodeDOM"));
            //CodeAttributeDeclaration assemblyLevelAttribute = new CodeAttributeDeclaration(new CodeTypeReference("DynamicCodeGeneration.CustomAttributes.AssemblyLevelAttribute"), arguments);//Create attribute to be added to assembly
            //unit.AssemblyCustomAttributes.Add(assemblyLevelAttribute);

            //unit.ReferencedAssemblies.Add("DynamicCodeGeneration.Base.dll");
            unit.ReferencedAssemblies.Add("System.dll");
            unit.ReferencedAssemblies.Add("System.Collections.Generic");
            unit.ReferencedAssemblies.Add(Path.Combine(Directory.GetCurrentDirectory(),"DataTransferObjects.dll"));
            #endregion

            #region Namespace
            CodeNamespace customEntityRoot = new CodeNamespace("GsfRulesValidator");//Create a namespace

            unit.Namespaces.Add(customEntityRoot);

            customEntityRoot.Imports.Add(new CodeNamespaceImport("System"));//Add references
            customEntityRoot.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));//Add references
            customEntityRoot.Imports.Add(new CodeNamespaceImport("DataTransferObjects"));//Add references
            #endregion

            #region Class
            CodeTypeDeclaration derived = new CodeTypeDeclaration(ClassName);//Create class

            customEntityRoot.Types.Add(derived);//Add the class to namespace defined above

            CodeConstructor derivedClassConstructor = new CodeConstructor();//Create constructor
            derivedClassConstructor.Attributes = MemberAttributes.Public;

            derived.Members.Add(derivedClassConstructor);//Add constructor to class

            //CodeAttributeArgument argument = new CodeAttributeArgument(new CodePrimitiveExpression("Karthik"));
            //CodeAttributeDeclaration classLevelAttribute = new CodeAttributeDeclaration(new CodeTypeReference("DynamicCodeGeneration.CustomAttributes.ClassLevelAttribute"), argument);//Create attribute to be added to class

            //derived.CustomAttributes.Add(classLevelAttribute);

            //derived.BaseTypes.Add(new CodeTypeReference("IDynamicCodeGenerator"));
            #endregion

            #region Method
            CodeMemberMethod derivedMethod = new CodeMemberMethod();
            derivedMethod.Attributes = MemberAttributes.Public; //Make this method an override of base class's method
            derivedMethod.Comments.Add(new CodeCommentStatement(new CodeComment("TestComment")));
            derivedMethod.Name = "Run";
            derivedMethod.ReturnType = new CodeTypeReference(this.ReturnType, CodeTypeReferenceOptions.GenericTypeParameter);
            var parameters = new CodeParameterDeclarationExpression();
            parameters = new CodeParameterDeclarationExpression(new CodeTypeReference(new CodeTypeParameter(this.ParameterType)), this.ParameterName);
            derivedMethod.Parameters.Add(parameters);
            //arguments = new CodeAttributeArgument[2];
            //arguments[0] = new CodeAttributeArgument(new CodeSnippetExpression("ComplexityLevel.SuperComplex"));//Create parameter for attribute
            //arguments[1] = new CodeAttributeArgument(new CodePrimitiveExpression("Karthik"));
            //CodeAttributeDeclaration methodLevelAttribute = new CodeAttributeDeclaration(new CodeTypeReference("DynamicCodeGeneration.CustomAttributes.MethodLevelAttribute"), arguments);//Create attribute to be added to method

            //derivedMethod.CustomAttributes.Add(methodLevelAttribute);//Add attribute to method

            CodeSnippetStatement code = new CodeSnippetStatement(MethodImplementaion);
            derivedMethod.Statements.Add(code);
            derived.Members.Add(derivedMethod);//Add method to the class
            #endregion

            #region Generate Code
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeGenerator codeGenerator = codeProvider.CreateGenerator();

            StringBuilder generatedCode = new StringBuilder();
            StringWriter codeWriter = new StringWriter(generatedCode);
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            options.BracingStyle = "C";//Keep the braces on the line following the statement or declaration that they are associated with
            codeGenerator.GenerateCodeFromCompileUnit(unit, codeWriter, options);
            #endregion
            this._code = generatedCode.ToString();
        }

        public string Compile()
        {
            try
            {
                ConstructClass();
                //     string ver = string.Format("{0}.{1}.{2}", Environment.Version.Major, Environment.Version.MajorRevision, Environment.Version.Build);
                //string exWpfDir = string.Format(@"C:\WINDOWS\Microsoft.NET\Framework\v{0}\WPF", ver);
                //string exDir = string.Format(@"C:\WINDOWS\Microsoft.NET\Framework\v{0}", ver);
                CSharpCodeProvider codeProvider = new CSharpCodeProvider(new Dictionary<String, String> { { "CompilerVersion", "v3.5" } });
                ICodeCompiler codeCompiler = codeProvider.CreateCompiler();
                CompilerParameters parameters = new CompilerParameters(new[] {"System.dll", "mscorlib.dll", "System.Core.dll", Path.Combine(Directory.GetCurrentDirectory(), "DataTransferObjects.dll") });
                parameters.GenerateInMemory = false;
                parameters.GenerateExecutable = false;
                parameters.GenerateInMemory = true;
                parameters.IncludeDebugInformation = false;
                parameters.TreatWarningsAsErrors = false;
                CompilerResults results = codeCompiler.CompileAssemblyFromSource(parameters, this.Code);

                if (results.Errors.HasErrors)
                {
                    string errorMessage = "";
                    errorMessage = results.Errors.Count.ToString() + " Errors:";
                    for (int x = 0; x < results.Errors.Count; x++)
                    {
                        errorMessage = errorMessage + "\r\nLine: " + results.Errors[x].Line.ToString() + " - " + results.Errors[x].ErrorText;
                    }
                    return errorMessage;
                }
                return results.PathToAssembly;
            }
            catch (Exception ex)
            {
                throw new Exception("Error while trying to build generated code.", ex);
            }
        }
    }
}
