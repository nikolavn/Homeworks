# Homework
## Incident Management

1. We have a painting program like Paint.NET and we have the following bugs
*	Set Priority and Severity

| Bug description        | Severity           | Priority  |
| ------------- |:-------------:| -----:|
|Tool for selection doesn�t select exactly the same that it�s marking (crops 10 pixels to the left)      | Critical | Immediate |
| When selecting a color with the color picker it replaces the first color from the palette, not the chosen one     | High  | Next Release |
| Shortcut for �Create New Image� (Ctrl+N) doesn�t work |  Medium | Next Release  |
| Spelling mistake in menu Select �Transperent selection� instead of �Transparent selection�| Low  |  Open |
| While holding Ctrl+Z and drawing with the pencil the second color is used instead of the first one, and that�s not a feature| Medium  |  On occasion |
| When using �Magic Wand� tool the tolerance value is changing on every mouse click| High  | Next Release  |
| While clicking �Rotate 90 Clockwise� the image is rotating in counterclockwise direction| Medium  | On occasion  |
| The button for increasing the Brush size doesn�t work. It can be increased only from the drop down | High  | Next Release  |
| Program crash on clicking the OK button while resizing an image.| Blocking  |  Immediate 

2.Imagine you have the following bug, mentioned by a customer and you have to describe it and log it in the bug tracking tool you use
*	Report the following bugs

|BUG REPORT |   #1   |
| ------------- |:-------------:| 
|Description  |When there�s a page break in the page and you try to set dashed border on the page, the bottom border line doesn�t show|
|Steps to reproduce  |1. Create new page <br/> 2. Create page break <br/>3. Set page border to **dashed**|
|Acceptance criteria  |All borders should be visible|
|Priority |**Next Release**|
|Severity  |**High**|

|BUG REPORT |   #2   |
| ------------- |:-------------:| 
|Description  |Application crash on clicking the Save button while creating a new user, hence unable to create a new user in the application.|
|Steps to reproduce  |1. Open the application <br/> 2. Click the button to create new user <br/> 3. Fill in information about the user <br/> 4. Click **"Save"** button|
|Acceptance criteria  |New user with entered information is successfully created and application doesn't crash|
|Priority |**Immediate**|
|Severity  |**Blocking**|

* Prepare another bug report
	* for the bug shown in this [video] (http://www.youtube.com/watch?v=xJg7k8QOGtM&feature=related)
	* for this sample defect: After logging into Gmail, it navigates to Google.com

|BUG REPORT |   #3  |
| ------------- |:-------------:| 
|Description  |Font changes to Symbol in Excel, when bullets are replaced on lists copied from Word|
|Steps to reproduce  |1. Open Word document <br/> 2. Create a list with point bullets <br/> 3. Copy the list <br/> 4. Open new Excel Sheet<br/>5. Paste the list in the Excel sheet (Keep source formatting or Ctrl+V)<br/>6. Select the bullet and the blank space up until the first letter of the list item and copy the selection <br/>7. Press Ctrl+H and paste the selection you copied under **Find What**<br/>8. Leave the **Replace with** blank and press **Replace All**|
|Acceptance criteria  |Bullets, on lists pasted from Word, should be removed after replaced with blank space in Excel|
|Priority |**On occasion**|
|Severity  |**Low**|


|BUG REPORT |   #4  |
| ------------- |:-------------:| 
|Description  |Page navigates to www.google.com after logging into Gmail|
|Steps to reproduce  |1. Open mail.google.com <br/> 2. Log-in with your credentials <br/> 
|Acceptance criteria  |Page should navigate to Gmail Inbox|
|Priority |**Immediate**|
|Severity  |**Critical**|
