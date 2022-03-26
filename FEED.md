## How to include an app in Common Apps using feed.json: ##

* You will need direct links for both x64 and x86 variants (if x64 or x86 is unavailable, just use either one)
* Official app title
* A tag, usually the app title - without spaces - preceded by a 'c'
* A PNG image - needs to be up to 256x256, should not exceed 50kb in size and must be with transparent background
* The group in which the app will be included to

## Available groups: ##

* SystemTools
* Internet
* Coding
* GraphicsSound

## Example: ##

```json
{
  "Title": "Google Chrome",
  "Link": "<link_x86>",
  "Link64": "<link_x64>",
  "Tag": "cChrome",
  "Image": "<link_to_png>",
  "Group": "Internet"
}
```
