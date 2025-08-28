<!-- Use this file to provide workspace-specific custom instructions to Copilot. For more details, visit https://code.visualstudio.com/docs/copilot/copilot-customization#_use-a-githubcopilotinstructionsmd-file -->

This is an MCP server project using .NET, now implemented as a console/stdio application. See https://modelcontextprotocol.io/llms-full.txt for protocol details and examples.

Workspace Guidance:
- Remove unnecessary files and dependencies; keep only MCP essentials.
- MCP server should support JSON-RPC 2.0 over stdio (stdin/stdout), not HTTP.
- Implement MCP lifecycle, capability negotiation, and car info tools.
- Ensure the project builds and runs offline as a self-contained console app.
- Document build and run instructions for offline/LLM integration in README.md.
