In the latest version XF 4.4.0.991265 text size in iOS in a WebView is significantly smaller almost too small to read, in previous versions the size matched Android.

This is a demo application demonstrating a simple webview with the issue

It is currently configured for XF 4.4.0.991265 
1. Run as is to confirm the issue that the text size is very small in the webview
2. Downgrade XF library to a previous released version (Tested with XF 4.2.0.709249) will show the previous normal text sizing that is similiar across platforms


XF 4.2.0.709249             |  XF 4.4.0.991265
:-------------------------:|:-------------------------:
<img src="https://user-images.githubusercontent.com/4401594/71337140-5f2bfc00-259e-11ea-8fb6-515be7e625b0.png" width="300" height="550"> | <img src="https://user-images.githubusercontent.com/4401594/71337143-62bf8300-259e-11ea-8b3f-6f2be8833779.png" width="300" height="550">
