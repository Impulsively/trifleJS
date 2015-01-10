﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrifleJS.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrifleJS.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* init.js
        ///*
        ///* By: Steven de Salas
        ///* On: Sep 2013
        ///* 
        ///*
        ///* Generates the core running environment for
        ///* javascript code to execute under
        ///* 
        ///*/
        ///
        ///(function(GLOBAL) {
        ///
        ///    // Save imported params
        ///    var API = {
        ///        phantom: GLOBAL.phantom,
        ///        trifle: GLOBAL.trifle,
        ///        console: GLOBAL.console,
        ///        decorate: function(obj, config) {
        ///			for (var prop in config) {
        ///				obj[prop] = config[prop];
        ///			}
        ///        }
        ///    };
        ///
        ///    delete GLOBAL.phantom;
        ///    delete GLOBAL.trifle;
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string bootstrap {
            get {
                return ResourceManager.GetString("bootstrap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///    json2.js
        ///    2013-05-26
        ///
        ///    Public Domain.
        ///
        ///    NO WARRANTY EXPRESSED OR IMPLIED. USE AT YOUR OWN RISK.
        ///
        ///    See http://www.JSON.org/js.html
        ///
        ///
        ///    This code should be minified before deployment.
        ///    See http://javascript.crockford.com/jsmin.html
        ///
        ///    USE YOUR OWN COPY. IT IS EXTREMELY UNWISE TO LOAD CODE FROM SERVERS YOU DO
        ///    NOT CONTROL.
        ///
        ///
        ///    This file creates a global JSON object containing two methods: stringify
        ///    and parse.
        ///
        ///        JSON.stringify(value, replacer, space [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ie_json2 {
            get {
                return ResourceManager.GetString("ie_json2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ////*
        ///// Initialize tools
        ///window.__tools = window.__tools || {};
        ///
        ///// Loads a JS file and executes a callback when ready
        ///window.__tools.includeJs = function(url, callbackId) {
        ///
        ///    window.external.xdebug([&apos;window.__tools.includeJs(url, callbackId)&apos;, url, callbackId]);
        ///
        ///    // Generate DOM for new &lt;script/&gt; tagg
        ///    var head = document.getElementsByTagName(&quot;head&quot;)[0] || document.documentElement;
        ///    var script = document.createElement(&quot;script&quot;);
        ///    script.id = &apos;script&apos; + callbackId;
        ///    script.sr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ie_tools {
            get {
                return ResourceManager.GetString("ie_tools", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var isCommonJS = typeof window == &quot;undefined&quot;;
        ///
        ////**
        ///* Top level namespace for Jasmine, a lightweight JavaScript BDD/spec/testing framework.
        ///*
        ///* @namespace
        ///*/
        ///var jasmine = {};
        ///if (isCommonJS) exports.jasmine = jasmine;
        ////**
        ///* @private
        ///*/
        ///jasmine.unimplementedMethod_ = function() {
        ///    throw new Error(&quot;unimplemented method&quot;);
        ///};
        ///
        ////**
        ///* Use &lt;code&gt;jasmine.undefined&lt;/code&gt; instead of &lt;code&gt;undefined&lt;/code&gt;, since &lt;code&gt;undefined&lt;/code&gt; is just
        ///* a plain old variable and may be redefined by some [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_lib_jasmine {
            get {
                return ResourceManager.GetString("test_lib_jasmine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to jasmine.ConsoleReporter = function(print, doneCallback, showColors) {
        ///    //inspired by mhevery&apos;s jasmine-node reporter
        ///    //https://github.com/mhevery/jasmine-node
        ///
        ///    doneCallback = doneCallback || function() { };
        ///
        ///    var ansi = {
        ///        green: &apos;\033[32m&apos;,
        ///        red: &apos;\033[31m&apos;,
        ///        yellow: &apos;\033[33m&apos;,
        ///        none: &apos;\033[0m&apos;
        ///    },
        ///    language = {
        ///        spec: &quot;spec&quot;,
        ///        failure: &quot;failure&quot;
        ///    };
        ///
        ///    function coloredStr(color, str) {
        ///        return showColors ? (ansi[c [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_lib_jasmine_console {
            get {
                return ResourceManager.GetString("test_lib_jasmine_console", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to describe(&quot;phantom global object&quot;, function() {
        ///    it(&quot;should exist&quot;, function() {
        ///        expect(typeof phantom).toEqual(&apos;object&apos;);
        ///    });
        ///
        ///    it(&quot;should have args property&quot;, function() {
        ///        expect(phantom.hasOwnProperty(&apos;args&apos;)).toBeTruthy();
        ///    });
        ///
        ///    it(&quot;should have args as an array&quot;, function() {
        ///        expect(typeof phantom.args).toEqual(&apos;object&apos;);
        ///    });
        ///
        ///    it(&quot;should have libraryPath property&quot;, function() {
        ///        expect(phantom.hasOwnProperty(&apos;libraryPath&apos;)).toBeTruthy( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_phantom_spec_phantom {
            get {
                return ResourceManager.GetString("test_phantom_spec_phantom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function checkClipRect(page, clipRect) {
        ///    expectHasProperty(page, &apos;clipRect&apos;);
        ///    it(&quot;should have clipRect with height &quot;+clipRect.height, function () {
        ///        expect(page.clipRect.height).toEqual(clipRect.height);
        ///    });
        ///    it(&quot;should have clipRect with left &quot;+clipRect.left, function () {
        ///        expect(page.clipRect.left).toEqual(clipRect.left);
        ///    });
        ///    it(&quot;should have clipRect with top &quot;+clipRect.top, function () {
        ///        expect(page.clipRect.top).toEqual(clipRect.top);
        ///    });
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_phantom_spec_webpage {
            get {
                return ResourceManager.GetString("test_phantom_spec_webpage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to describe(&quot;WebServer constructor&quot;, function() {
        ///    it(&quot;should not exist in window&quot;, function() {
        ///        expect(window.hasOwnProperty(&apos;WebServer&apos;)).toBeFalsy();
        ///    });
        ///
        ///    it(&quot;should be a function&quot;, function() {
        ///        var WebServer = require(&apos;webserver&apos;).create;
        ///        expect(typeof WebServer).toEqual(&apos;function&apos;);
        ///    });
        ///});
        ///
        ///var expectedPostData = false, expectedBinaryData = false;
        ///
        ///function checkRequest(request, response) {
        ///	console.log(&apos;checking request...&apos;);
        ///    expect(typeof reques [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_phantom_spec_webserver {
            get {
                return ResourceManager.GetString("test_phantom_spec_webserver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///// Add Helper Functions
        ///function expectHasFunction(o, name) {
        ///    it(&quot;should have &apos;&quot; + name + &quot;&apos; function&quot;, function() {
        ///        expect(typeof o[name]).toEqual(&apos;function&apos;);
        ///    });
        ///}
        ///
        ///function expectHasProperty(o, name) {
        ///    it(&quot;should have &apos;&quot; + name + &quot;&apos; property&quot;, function() {
        ///        expect(o.hasOwnProperty(name)).toBeTruthy();
        ///    });
        ///}
        ///
        ///function expectHasPropertyString(o, name) {
        ///    expectHasProperty(o, name);
        ///
        ///    it(&quot;should have &apos;&quot; + name + &quot;&apos; as a string&quot;, function() {
        ///        e [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_phantom_tools {
            get {
                return ResourceManager.GetString("test_phantom_tools", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///// Launch tests
        ///var jasmineEnv = jasmine.getEnv();
        ///
        ///// Add a ConsoleReporter to 
        ///// 1) print with colors on the console 
        ///// 2) exit when finished
        ///jasmineEnv.addReporter(new jasmine.ConsoleReporter(function(msg) {
        ///    // Apply color
        ///    var ansi = {
        ///        green: &apos;\033[32m&apos;,
        ///        red: &apos;\033[31m&apos;,
        ///        yellow: &apos;\033[33m&apos;,
        ///        none: &apos;\033[0m&apos;,
        ///        newline: &apos;\n&apos;
        ///    };
        ///    msg = msg.replace(ansi.newline, &apos;&apos;).replace(ansi.none, &apos;&apos;);
        ///    var printInColor = function(color, message) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_run_jasmine {
            get {
                return ResourceManager.GetString("test_run_jasmine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///console.log();
        ///console.log(&apos;-------------------------------&apos;);
        ///console.log(&apos;  TESTING COMPLETED&apos;);
        ///console.log(&apos;-------------------------------&apos;);
        ///console.log(&apos;Total Tests: &apos; + assert.count);
        ///
        ///if (assert.fail.count) { console.API.color(&apos;red&apos;, &apos;Total Failed: &apos; + assert.fail.count); }
        ///else { console.API.color(&apos;green&apos;, &apos;Total Passed: &apos; + assert.pass.count); }
        ///
        ///console.log();
        ///.
        /// </summary>
        internal static string test_unit_finish {
            get {
                return ResourceManager.GetString("test_unit_finish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* child_process.js
        ///* 
        ///* Runs a set of unit tests used that check
        ///* the functionality of the child process object
        ///* 
        ///*/
        ///
        ///
        ///assert.suite(&apos;Module: ChildProcess&apos;, function() {
        ///
        ///	var child_process = require(&quot;child_process&quot;);
        ///	var checker = {child_process: child_process};
        ///	// --------------------------------------------
        ///	assert.section(&apos;Instantiation&apos;);
        ///	// --------------------------------------------
        ///
        ///	assert(!!child_process, &apos;child_process can be instantiated using require()&apos;);
        ///	assert(typeo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_unit_spec_child_process {
            get {
                return ResourceManager.GetString("test_unit_spec_child_process", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* env.js
        ///* 
        ///* Runs a set of unit tests used that check
        ///* global objects and special functions used
        ///* in the V8 execution context.
        ///*
        ///* Most of the functionality here is defined
        ///* in bootstrap.js
        ///* 
        ///*/
        ///
        ///assert.suite(&apos;Global Environment&apos;, function() {
        ///
        ///	// --------------------------------------------
        ///	assert.section(&apos;Global objects&apos;, function() {
        ///	
        ///		this[&apos;GLOBAL&apos;] = this;
        ///	
        ///		assert.checkMembers(this, &apos;GLOBAL&apos;, {
        ///			&apos;window&apos;: &apos;object&apos;,
        ///			&apos;navigator&apos;: &apos;object&apos;,
        ///			&apos;location&apos;: &apos;object&apos; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_unit_spec_env {
            get {
                return ResourceManager.GetString("test_unit_spec_env", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* fs.js
        ///* 
        ///* Runs a set of unit tests used that check
        ///* the functionality of the filesystem object
        ///* 
        ///*/
        ///
        ///assert.suite(&apos;Module: FileSystem&apos;, function() {
        ///
        ///	// SETUP
        ///	var fs = require(&quot;fs&quot;);
        ///	var testdir = &quot;test&quot;;
        ///	var fsdir = testdir + &quot;/fs&quot;;
        ///	var workingDirectory = fs.workingDirectory;
        ///
        ///	// --------------------------------------------
        ///	assert.section(&apos;Instantiation&apos;);
        ///	// --------------------------------------------
        ///
        ///	assert(!!fs, &apos;fs can be instantiated using require()&apos;);
        ///	assert(t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_unit_spec_fs {
            get {
                return ResourceManager.GetString("test_unit_spec_fs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* phantom.js
        ///* 
        ///* Runs a set of unit tests used that check
        ///* the functionality of the global &apos;phantom&apos; object.
        ///* 
        ///*/
        ///
        ///
        ///assert.suite(&apos;Object: phantom&apos;, function() {
        ///
        ///	// SETUP
        ///	var fs = require(&apos;fs&apos;);
        ///	var server = require(&apos;webserver&apos;).create();
        ///	var page = require(&apos;webpage&apos;).create();
        ///	
        ///	// --------------------------------------------
        ///	assert.section(&apos;Object availability&apos;);
        ///
        ///	assert(this.hasOwnProperty(&apos;phantom&apos;), &apos;this.phantom exists&apos;);
        ///	assert(typeof this.phantom === &apos;object&apos;, &apos;this [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_unit_spec_phantom {
            get {
                return ResourceManager.GetString("test_unit_spec_phantom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* require.js
        ///* 
        ///* Runs a set of unit tests used to verify the 
        ///* commonJS module functionality.
        ///* 
        ///*/
        ///
        ///assert.suite(&apos;CommonJS functionality&apos;, function() {
        ///
        ///    assert.section(&apos;Globals&apos;);
        ///    
        ///    assert(typeof require === &apos;function&apos;, &apos;require is a function&apos;);
        ///
        ///    assert.section(&apos;Calling Inbuilt Modules&apos;);
        ///
        ///    var fs = require(&apos;fs&apos;);
        ///    assert(typeof fs === &apos;object&apos;, &apos;fs module can be instantiated&apos;);
        ///    assert(typeof fs.workingDirectory === &apos;string&apos;, &apos;fs module contains a workingDire [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_unit_spec_require {
            get {
                return ResourceManager.GetString("test_unit_spec_require", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* webpage.js
        ///* 
        ///* Runs a set of unit tests used to verify the 
        ///* functionality of the webpage module.
        ///* 
        ///*/
        ///
        ///assert.suite(&apos;Module: WebPage&apos;, function() {
        ///
        ///	// SETUP
        ///	var fs = require(&apos;fs&apos;);
        ///	var server = require(&apos;webserver&apos;).create();
        ///	var loadCount = 0;
        ///
        ///	// --------------------------------------------
        ///	assert.section(&apos;Instantiation&apos;);
        ///
        ///	assert(this.hasOwnProperty(&apos;WebPage&apos;), &apos;this.WebPage exists&apos;);
        ///	assert(typeof this.WebPage === &apos;function&apos;, &apos;this.WebPage is a function&apos;);
        ///	assert(wi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_unit_spec_webpage {
            get {
                return ResourceManager.GetString("test_unit_spec_webpage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* webserver.js
        ///* 
        ///* Runs a set of unit tests used that check
        ///* the the functionality in the webserver module
        ///* 
        ///*/
        ///
        ///assert.suite(&apos;Module: WebServer&apos;, function() {
        ///
        ///	// SETUP
        ///	var fs = require(&quot;fs&quot;);
        ///	var server = require(&apos;webserver&apos;).create();
        ///	var page = require(&apos;webpage&apos;).create();
        ///	var workingDirectory = fs.workingDirectory;
        ///	var loadCount = 0;
        ///	var helloWorldListener = function(request, response) { loadCount++; response.write(&quot;Hello World&quot;); response.close(); }
        ///	var helloWorld2Listen [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_unit_spec_webserver {
            get {
                return ResourceManager.GetString("test_unit_spec_webserver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///var assert = function(condition, message) {
        ///	assert.n++;
        ///	assert.count++;
        ///    if (condition !== true) {
        ///       assert.fail(message);
        ///    } else {
        ///       assert.pass(message);
        ///    }
        ///}
        ///
        ///assert.count = 0;
        ///
        ///assert.pass = function(message) {
        ///	console.API.color(&apos;green&apos;, assert.n + &apos;. PASS: &apos; + (message || &apos;(no message)&apos;) + &apos;.&apos;);
        ///    assert.pass.count++;
        ///}
        ///
        ///assert.pass.count = 0;
        ///
        ///assert.fail = function(message) {
        ///	console.API.color(&apos;red&apos;, assert.n + &apos;. FAIL: &apos; + (message || &apos;(no message)&apos;) + [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string test_unit_tools {
            get {
                return ResourceManager.GetString("test_unit_tools", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* Callback.js
        ///*
        ///* By: Steven de Salas
        ///* On: Sep 2013
        ///* 
        ///* Generates a Callback object used for async
        ///* communication between V8 and C# runtime.
        ///* 
        ///*/
        ///
        ///// Initialise Namespace
        ///this.trifle = this.trifle || {};
        ///
        ///// Wrap code to avoid global vars
        ///(function(trifle) {
        ///
        ///    // Closure variable that tracks existing callbacks
        ///    // (hidden from outside world)
        ///    var callbacks = {};
        ///
        ///    // Callback Class
        ///    // Define Constructor
        ///    var Callback = trifle.Callback = function(func, scope,  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string trifle_Callback {
            get {
                return ResourceManager.GetString("trifle_Callback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* ChildProcess.js
        ///*
        ///* By: Steven de Salas
        ///* On: Jan 2015
        ///* 
        ///* Defines a ChildProcess class representing a
        ///* helper to spawn and manage new child processes
        ///* 
        ///*/
        ///
        ///// Initialise Namespace
        ///this.trifle = this.trifle || {};
        ///trifle.modules = trifle.modules || {};
        ///
        ///// Wrap code to avoid global vars
        ///(function(trifle) {
        ///
        ///    // Define Module
        ///    var ChildProcess = trifle.modules.ChildProcess = trifle.extend({
        ///		
        ///		// Derives functionality from ChildProcess.cs
        ///		module: trifle.API.ChildProces [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string trifle_modules_ChildProcess {
            get {
                return ResourceManager.GetString("trifle_modules_ChildProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* FileSystem.js
        ///*
        ///* By: Steven de Salas
        ///* On: Sep 2013
        ///* 
        ///* Defines a FileSystem class representing a
        ///* helper for file read/write operations and management.
        ///* 
        ///*/
        ///
        ///// Initialise Namespace
        ///this.trifle = this.trifle || {};
        ///trifle.modules = trifle.modules || {};
        ///
        ///// Wrap code to avoid global vars
        ///(function(trifle) {
        ///
        ///
        ///    // Define Module
        ///    var FileSystem = trifle.modules.FileSystem = trifle.extend({
        ///		
        ///		// Derives functionality from FileSystem.cs
        ///		module: trifle.API.FileSystem,        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string trifle_modules_FileSystem {
            get {
                return ResourceManager.GetString("trifle_modules_FileSystem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* System.js
        ///*
        ///* By: Steven de Salas
        ///* On: Sep 2013
        ///* 
        ///* Defines a System class representing a
        ///* general program helper.
        ///* 
        ///*/
        ///
        ///// Initialise Namespace
        ///this.trifle = this.trifle || {};
        ///trifle.modules = trifle.modules || {};
        ///
        ///// Wrap code to avoid global vars
        ///(function(trifle) {
        ///
        ///
        ///    // Define Module
        ///    var System = trifle.modules.System = trifle.extend({
        ///    
        ///		// Derives functionality from System.cs
        ///		module: trifle.API.System,
        ///		
        ///		// Constructor
        ///		init: function() {
        ///			cons [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string trifle_modules_System {
            get {
                return ResourceManager.GetString("trifle_modules_System", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* WebPage.js
        ///*
        ///* By: Steven de Salas
        ///* On: Sep 2013
        ///* 
        ///* Defines an object representing a
        ///* browser page opened inside IE environment.
        ///* 
        ///*/
        ///
        ///// Initialise Namespace
        ///this.trifle = this.trifle || {};
        ///this.trifle.modules = this.trifle.modules || {};
        ///
        ///// Wrap code to avoid global vars
        ///(function (trifle) {
        ///
        ///    // Define Module
        ///    var WebPage = this.WebPage = window.WebPage = trifle.modules.WebPage = trifle.extend({
        ///		
        ///		// Derives functionality from WebPage.cs
        ///		module: trifle.API.Web [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string trifle_modules_WebPage {
            get {
                return ResourceManager.GetString("trifle_modules_WebPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* WebServer.js
        ///*
        ///* By: Steven de Salas
        ///* On: Jan 2014
        ///* 
        ///* Defines a WebServer class representing a
        ///* HTTP Daemon.
        ///* 
        ///*/
        ///
        ///// Initialise Namespace
        ///this.trifle = this.trifle || {};
        ///trifle.modules = trifle.modules || {};
        ///
        ///// Wrap code to avoid global vars
        ///(function (trifle) {
        ///
        ///    // Define Module
        ///    var WebServer = trifle.modules.WebServer = trifle.extend({
        ///		
        ///		// Derives functionality from WebServer.cs
        ///		module: trifle.API.WebServer,
        ///		
        ///		// Constructor
        ///		init: function() {
        ///			 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string trifle_modules_WebServer {
            get {
                return ResourceManager.GetString("trifle_modules_WebServer", resourceCulture);
            }
        }
    }
}
