# Blockchain

Simple .NET Core Web API application that retrieves a few parameters of all unspent transaction outputs of a given address.

# How to run

## Using Visual Studio Code

* Open project folder with Visual Studio Code.
* Select Debug view on left column (or Ctrl+Shift+D)
* Click play button or hit F5

Note: Make sure you have C# Extension installed

## Using Command Line

Navigate to project folder and run the following command

* dotnet run


# How to use

While app is running visit http://localhost:5000/address/$address in the browser or use external tools such as Postman or curl. 

$address must be a valid non bech32 bitcoin address.

Example: http://localhost:5000/address/1Aff4FgrtA1dZDwajmknWTwU2WtwUvfiXa

# Requirements

* .NET Core 2.1 SDK: Download from www.dot.net and follow install instructions for desired platform.
