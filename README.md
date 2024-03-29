# Korexio.Templates

A custom template for dotnet new.

## Install

The templates can be installed via

```powershell
dotnet new install Korexio.Templates
```

This will install the latest version of the NuGet package.

## Use

The templates can be used via

```powershell
dotnet new prototype --output './Artifacts/My.Demo' --name 'My.Demo'
```

This will instantiate the template in the `./Artifacts/My.Demo` directory.

## Uninstall

First check which templates are installed

```powershell
dotnet new uninstall
```

then execute the displayed command to uninstall the templates

```powershell
dotnet new uninstall Korexio.Templates
```

## References

| Title                             | Version    | Link | Keywords |
| --------------------------------- | ---------- | ---- | -------- |
| *Custom templates for dotnet new* | 2.37.3     | [https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates) | `.template.config` |
| *gitattributes*                   | 2.37.3     | [https://www.git-scm.com/docs/gitattributes](https://www.git-scm.com/docs/gitattributes) | `.gitattributes` |
| *EditorConfig*                    | 0.14.0     | [https://editorconfig-specification.readthedocs.io/](https://editorconfig-specification.readthedocs.io/) | `.editorconfig` |
| *GitHub Flavored Markdown Spec*   | 0.29-gfm   | [https://github.github.com/gfm/](https://github.github.com/gfm/) | `.md` |
| *Customize your build*            | 2022-06-09 | [https://docs.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2022](https://docs.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2022) | `Directory.Build.props` |
| *Semantic Versioning 2.0.0*       | 2.0.0      | [https://semver.org/spec/v2.0.0.html](https://semver.org/spec/v2.0.0.html) ||
| *About workflows*                 | 2022-09-16 | [https://docs.github.com/en/actions/using-workflows/about-workflows](https://docs.github.com/en/actions/using-workflows/about-workflows) | `.github` `.yaml` |
