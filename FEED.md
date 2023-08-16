# Including an App in Common Apps using feed.json

To include an app in Common Apps using the `feed.json` file, follow these steps:

## Prerequisites

You will need the following information:

- Direct download links for both x64 and x86 variants of the app (if one variant is unavailable, provide the available variant).
- Official app title.
- A tag, usually the app title without spaces, preceded by a 'c'.
- A PNG image with a transparent background, up to 256x256 pixels in size and not exceeding 50KB.
- The group in which the app will be categorized.

## Available Groups

Choose one of the available groups to categorize your app:

- SystemTools
- Internet
- Coding
- GraphicsSound

## Example

Here's an example of how to structure your entry in the `feed.json` file:

```json
{
  "Title": "Google Chrome",
  "Link": "<link_x86>",
  "Link64": "<link_x64>",
  "Tag": "cChrome",
  "Image": "<link_to_png>",
  "Group": "Internet"
}
