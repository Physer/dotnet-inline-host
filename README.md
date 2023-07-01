# DotnetInlineHost

## Introduction

DotnetInlineHost is a small utility package that allows you to quickly spin up an IHost instance with the option to pass along a custom configuration provider as simple key-values.
A use-case of this utility is in Integration Tests where you can quickly spin up a host with custom configuration data without writing your own JSON appsettings.

## How to use

Install the DotnetInlineHost package through the NuGet UI in Visual Studio or use the command line:

Dotnet CLI: `dotnet add package DotnetInlineHost --version 0.1.0`

Nuget Package manager: `Install-Package DotnetInlineHost -Version 0.1.0`

This tool and its README are a work-in-progress. Stay tuned for more.
