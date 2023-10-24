using Autodesk.Revit.ApplicationServices;
using NUnit.Framework;
using System;
using System.Globalization;

[assembly: System.Reflection.AssemblyMetadata("NUnit.Open", "true")]
[assembly: System.Reflection.AssemblyMetadata("NUnit.Close", "true")]

#if RELEASE_EN
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "en")]
#endif
#if RELEASE_ENG
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "ENG")]
#endif
#if RELEASE_FR
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "fr")]
#endif
#if RELEASE_DE
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "de")]
#endif
#if RELEASE_IT
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "it")]
#endif
#if RELEASE_JA
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "ja")]
#endif
#if RELEASE_KO
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "ko")]
#endif
#if RELEASE_PL
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "pl")]
#endif
#if RELEASE_ES
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "es")]
#endif
#if RELEASE_ZH
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "zh")]
#endif
#if RELEASE_ZHT
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "CHT")]
#endif
#if RELEASE_PT
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "pt")]
#endif
#if RELEASE_RU
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "ru")]
#endif
#if RELEASE_CS
[assembly: System.Reflection.AssemblyMetadata("NUnit.Language", "cs")]
#endif

namespace RevitTest.Language
{
    public class Tests
    {
        private Application application;

        [SetUp]
        public void Setup(Application application)
        {
            this.application = application;
        }

        [Test]
        public void TestLanguage()
        {
            var cultureInfo = CultureInfo.CurrentUICulture;
            Console.WriteLine(cultureInfo.Name);
            Console.WriteLine(application.Language);

#if RELEASE_EN
            Assert.AreEqual("en-US", cultureInfo.Name);
            Assert.AreEqual(LanguageType.English_USA, application.Language);
#endif
#if RELEASE_ENG
            Assert.AreEqual("en-GB", cultureInfo.Name);
            Assert.AreEqual(LanguageType.English_GB, application.Language);
#endif
#if RELEASE_FR
            Assert.AreEqual("fr-FR", cultureInfo.Name);
            Assert.AreEqual(LanguageType.French, application.Language);
#endif
#if RELEASE_DE
            Assert.AreEqual("de-DE", cultureInfo.Name);
            Assert.AreEqual(LanguageType.German, application.Language);
#endif
#if RELEASE_IT
            Assert.AreEqual("it-IT", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Italian, application.Language);
#endif
#if RELEASE_JA
            Assert.AreEqual("ja-JP", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Japanese, application.Language);
#endif
#if RELEASE_KO
            Assert.AreEqual("ko-KR", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Korean, application.Language);
#endif
#if RELEASE_PL
            Assert.AreEqual("pl-PL", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Polish, application.Language);
#endif
#if RELEASE_ES
            Assert.AreEqual("es-ES", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Spanish, application.Language);
#endif
#if RELEASE_ZH
            Assert.AreEqual("zh-CN", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Chinese_Simplified, application.Language);
#endif
#if RELEASE_ZHT
            Assert.AreEqual("zh-TW", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Chinese_Traditional, application.Language);
#endif
#if RELEASE_PT
            Assert.AreEqual("pt-BR", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Brazilian_Portuguese, application.Language);
#endif
#if RELEASE_RU
            Assert.AreEqual("ru-RU", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Russian, application.Language);
#endif
#if RELEASE_CS
            Assert.AreEqual("cs-CZ", cultureInfo.Name);
            Assert.AreEqual(LanguageType.Czech, application.Language);
#endif
        }
    }
}