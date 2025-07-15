# Uno Platform Development Guide for AI Agents

## Architecture Overview

Uno Platform is a multi-platform UI framework that allows C# and WinUI XAML code to run on all platforms with native performance. The key architectural pattern is **platform abstraction through target frameworks**.

### Core Structure
- **`src/Uno.UI/`** - Main UI implementation with platform-specific code
- **`src/Uno.Foundation/`** - Base APIs and platform abstractions  
- **`src/SourceGenerators/`** - XAML and binding code generation
- **`src/SamplesApp/`** - Multi-platform sample application for testing
- **`build/`** - Build scripts and CI configuration

### Platform Targeting Strategy
Uno uses **target framework monikers (TFMs)** to differentiate platforms:
- `net9.0-windows10.0.xxxx` - Windows App SDK/WinUI (native Windows)
- `net9.0-browserwasm` - WebAssembly
- `net9.0-android` - Android
- `net9.0-ios` - iOS
- `net9.0-maccatalyst` - Mac Catalyst
- `net9.0-desktop` - Skia Desktop (Windows/macOS/Linux)

## Platform-Specific Code Patterns

### File Naming Conventions (Uno.Sdk projects)
```
MyClass.cs          // Shared code
MyClass.wasm.cs     // WebAssembly only
MyClass.android.cs  // Android only  
MyClass.iOS.cs      // iOS and Mac Catalyst
MyClass.desktop.cs  // Skia Desktop
MyClass.reference.cs // Reference implementation only
```

### Conditional Compilation Symbols
```csharp
#if __ANDROID__     // Android
#if __IOS__         // iOS
#if __WASM__        // WebAssembly  
#if __DESKTOP__     // Skia Desktop
#if __UNO_SKIA__    // Any Skia renderer
#if __UNO__         // Any Uno platform (not Windows)
```

### Native Interface Pattern
Platform-specific implementations use the `INativeXXX` interface pattern:
```csharp
// Platform abstraction in shared code
interface INativeWebView { void Navigate(Uri uri); }

// Platform-specific implementations
partial class UnoWKWebView : INativeWebView  // iOS/macOS
partial class UnoWebView : INativeWebView    // Android
```

## Development Workflows

### Single-Platform Development
For faster builds, target single platform using `crosstargeting_override.props`:
```xml
<UnoTargetFrameworkOverride>net9.0-ios</UnoTargetFrameworkOverride>
```

### Build Commands
```bash
# Build for specific platform
dotnet build -f net9.0-android

# Full solution build (slower)
msbuild Uno.UI.Build.csproj
```

### Running SamplesApp
The `SamplesApp` contains comprehensive UI samples:
- `SamplesApp.Skia/` - Desktop testing
- `SamplesApp.Wasm/` - WebAssembly testing  
- `SamplesApp.netcoremobile/` - Mobile testing

## Key Dependencies & Integration Points

### Source Generators
- **XAML compilation** happens in `Uno.UI.SourceGenerators`
- Generated files in `Generated/` folders (auto-generated, don't edit)
- Test generator behavior in `XamlGenerationTests/`

### WebView Integration
WebView follows a three-layer pattern:
1. `WebView2` control (public API)
2. `CoreWebView2` (shared logic)  
3. `INativeWebView` (platform-specific, e.g., `WKWebView` on iOS)

### Cross-Platform Runtime Detection
```csharp
// Runtime platform detection
if (OperatingSystem.IsBrowser()) { /* WebAssembly */ }
if (OperatingSystem.IsAndroid()) { /* Android */ }

// Build-time platform detection  
RuntimeTestsPlatformHelper.CurrentPlatform
```

## Solution Filter Usage
Large solutions use `.slnf` filters for focused development:
- `Uno.UI-Wasm-only.slnf` - WebAssembly development
- `Uno.UI-Skia-only.slnf` - Desktop development
- `Uno.UI-netcoremobile-only.slnf` - Mobile development

## Common Patterns to Follow

1. **Platform abstraction**: Use interfaces and partial classes rather than large `#if` blocks
2. **Target framework conditional**: Use file naming conventions over conditional compilation when possible
3. **Testing strategy**: Add samples to `SamplesApp` for manual testing, unit tests in `RuntimeTests`
4. **Source generation**: XAML changes require testing in `XamlGenerationTests` project

## Performance Considerations

- Don't build the project yourself; when you make changes, suggest the actions and/or tests to run.
