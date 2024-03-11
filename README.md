# DAR-to-OAR [![.NET](https://github.com/allison-payne/dar-to-oar/actions/workflows/dotnet.yml/badge.svg)](https://github.com/allison-payne/dar-to-oar/actions/workflows/dotnet.yml)
A Tool for automating the conversion DAR mods to OAR mods.

Batch version.

It will automatically rename `DynamicAnimationReplacer` to `.DynamicAnimationReplacer`.

## What it does

This tool converts a DAR mod to an OAR mod. It copies all the files from the ``DynamicAnimationReplacer`` folder to the ``OpenAnimationReplacer`` folder, then generates the JSON files needed at each level. To keep things simple, the numbered folders of preserved, this also makes determining priority in config generation much easier.

For a list of supported DAR conditions see this [list](Checklist.md)

## How to use
1. Simply provide the Mod Organizer 2 mods folder you wish to convert and add an optional author name.
2. Click Convert and wait until popup message.

## TODO
- Additional Error handling 
- Additional User messaging
- Progress bar