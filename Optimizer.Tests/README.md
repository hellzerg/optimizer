# App download regression tests

Run on Windows with the .NET Framework 4.8 Developer Pack and .NET SDK 8 or newer:

```powershell
dotnet test .\Optimizer.Tests\Optimizer.Tests.csproj --configuration Release
```

The tests compile the production download-state and progress helpers directly. They do not launch Optimizer, run installers, apply optimizations, or access system configuration. Feed URLs in the state tests use the reserved `.invalid` domain and are never requested.

Coverage includes unknown or zero content lengths, large byte counts, percentage bounds, exclusive feed/download operations, stable batch inputs, and state recovery after invalid inputs. Loopback-only HTTP tests verify that a real chunked download reports unknown-length progress on a Windows Forms synchronization context, including cancellation and timeout cleanup. Downloaded bytes are inert test data in a temporary folder, never executable content.

These are helper and HTTP-contract tests, not an end-to-end test of MainForm or the installer workflow.
