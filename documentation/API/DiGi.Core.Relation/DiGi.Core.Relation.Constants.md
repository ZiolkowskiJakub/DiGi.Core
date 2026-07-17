#### [DiGi\.Core\.Relation](DiGi.Core.Relation.Overview.md 'DiGi\.Core\.Relation\.Overview')

## DiGi\.Core\.Relation\.Constants Namespace
### Classes

<a name='DiGi.Core.Relation.Constants.ReferenceKind'></a>

## ReferenceKind Class

Discriminator tokens for the reference types defined in DiGi\.Core\.Relation\.

These values are a persisted contract: they are written into stored reference strings, so they are
            append-only. Renaming one silently invalidates every string already stored in that format. A token must be
            unique across every repository, and must contain neither a comma (which would make it parse as a full type
            name) nor a colon.

This class is deliberately NOT named Reference. A local Constants.Reference would win innermost-namespace
            lookup over DiGi.Core.Constants.Reference and silently shadow the shared grammar constants - a bug this
            codebase has already had once, in DiGi.PostgreSQL.

```csharp
public static class ReferenceKind
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ReferenceKind
### Fields

<a name='DiGi.Core.Relation.Constants.ReferenceKind.RelationListCluster'></a>

## ReferenceKind\.RelationListCluster Field

Discriminator for [RelationListClusterReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListClusterReference 'DiGi\.Core\.Relation\.Classes\.RelationListClusterReference')\.

```csharp
public const string RelationListCluster = "RelationListCluster";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')