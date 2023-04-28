Set-PSDebug -Trace 1

$external_docs =
@(
    # use either commit or branch name (latest commit) in 3rd argument
    @("https://github.com/unoplatform/uno.wasm.bootstrap", "uno.wasm.bootstrap", "main"),
    @("https://github.com/unoplatform/uno.themes", "uno.themes", "master"),
    @("https://github.com/unoplatform/uno.toolkit.ui", "uno.toolkit.ui", "main"),
    @("https://github.com/unoplatform/uno.check", "uno.check", "main"),
    @("https://github.com/unoplatform/uno.xamlmerge.task", "uno.xamlmerge.task", "main"),
    @("https://github.com/unoplatform/figma-docs", "figma-docs", "main"),
    @("https://github.com/unoplatform/uno.resizetizer", "uno.resizetizer", "main"),
    @("https://github.com/unoplatform/uno.uitest", "uno.uitest", "master"),
    @("https://github.com/unoplatform/uno.extensions", "uno.extensions", "dev/shimmy/mvux-docs-advanced")
)

$ErrorActionPreference = 'Stop'

function Assert-ExitCodeIsZero()
{
    if ($LASTEXITCODE -ne 0)
    {
        popd
        popd

        Set-PSDebug -Off

        throw "Exit code must be zero."
    }
}

if (Test-Path articles\external)
{
    del -recurse -force articles\external
}

mkdir articles\external -ErrorAction Continue
pushd articles\external

# ensure long paths are supported on Windows
git config --global core.longpaths true

# Heads - Release
for ($i = 0; $i -lt $external_docs.Length; $i++)
{
    $repoUrl=$external_docs[$i][0]
    $repoPath=$external_docs[$i][1]
    $repoBranch=$external_docs[$i][2]

    echo "Cloning $repoPath ($repoUrl@$repoBranch)"

    git clone $repoUrl $repoPath
    Assert-ExitCodeIsZero

    pushd $repoPath
    git checkout $repoBranch
    Assert-ExitCodeIsZero
    popd
}

popd

docfx

Assert-ExitCodeIsZero

dotnet-serve --open-browser
