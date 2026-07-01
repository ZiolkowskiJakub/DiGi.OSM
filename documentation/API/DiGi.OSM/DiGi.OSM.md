#### [DiGi\.OSM](index.md 'index')

## DiGi\.OSM Namespace
### Classes

<a name='DiGi.OSM.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.OSM.Query.Test(string,long)'></a>

## Query\.Test\(string, long\) Method

Tests the processing of OpenStreetMap data by reading a file, filtering for specific nodes or ways based on an identifier, and converting them to spatial features\.

```csharp
public static void Test(string path, long id=407692677L);
```
#### Parameters

<a name='DiGi.OSM.Query.Test(string,long).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path to the OSM source data\.

<a name='DiGi.OSM.Query.Test(string,long).id'></a>

`id` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The unique identifier used to filter specific OSM elements\.