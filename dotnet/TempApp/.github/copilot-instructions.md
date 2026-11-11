# Copilot Instructions for TempApp

These instructions guide AI coding agents to follow project conventions and user preferences for this repository.

## General Principles
- Keep changes minimal and focused to the requested task. Avoid unrelated refactors.
- Use the `dotnet` CLI for all build and test operations.
- Respect nullable reference types; keep public APIs null-aware.
- When in doubt, run the build and tests first, and report failures with exact commands and outputs.

## File and Technology Scope
- Applies to all C# source files (`*.cs`) in this repository.
- Applies to both the console app and test project.

## Enforced Patterns
- Use `Utils.ComputeHash` for MD5 hashing logic.
- Add or update tests in `TempAppTestsXUnit` for any changes to hashing or CLI logic.
- Do not introduce new dependencies unless required by the task.
- Remove unused code and package references when found.

## Example Prompts
- "Add a test for ComputeHash with a salt value."
- "Remove the unused Newtonsoft.Json package."
- "Fix spelling in all .cs files."

## Related Customizations to Consider
- Add a spelling-check or formatting hook for C# files.
- Create a separate instructions file for test conventions if the test suite grows.

---
Generated to help AI agents be productive and consistent in this codebase.
