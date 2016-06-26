﻿using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using libyaraNET;

namespace Tests
{
    [TestClass]
    public class describe_Compiler
    {
        Compiler compiler;
        YaraContext ctx;

        [TestInitialize]
        public void before_each()
        {
            ctx = new YaraContext();
            compiler = new Compiler();
        }

        [TestCleanup]
        public void after_each()
        {
            ctx.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(CompilationException))]
        public void given_invalid_rule_add_rule_string_should_throw()
        {
            compiler.AddRuleString("invalid rule");
        }

        [TestMethod]
        [ExpectedException(typeof(Win32Exception))]
        public void given_missing_rule_file_add_rule_file_should_throw()
        {
            compiler.AddRuleFile("c:\\notfound.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(CompilationException))]
        public void given_invalid_rule_file_add_rule_file_should_throw()
        {
            compiler.AddRuleFile(".\\Content\\InvalidRule.yara");
        }
    }
}
