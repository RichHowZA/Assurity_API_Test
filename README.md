# API Acceptance Test

Using the API given below create an automated test with the listed acceptance criteria:
API = https://api.tmsandbox.co.nz/v1/Categories/6327/Details.json?catalogue=false

## 1. Acceptance Criteria:

 - Name = "Carbon credits"
 - CanRelist = true
 - The Promotions element with Name = "Gallery" has a Description that contains the text "2x larger image"

## 2. Language and framework used

 - C-Sharp was used as the programming language using Visual Studio 2017 communtiy addition
 - Specflow was used as a framework in conjunction with nunit
 
## 3. Files needed to execute test

 - APIFramework.dll
 - Newtonsoft.Json.dll
 - nunit.framework.dll
 - nunit.engine.api.dll
 - nunit.engine.dll
 - NUnit3.TestAdapter.dll
 - RestSharp.dll
 - System.ValueTuple.dll
 - TechTalk.SpecFlow.dll
 
 Location for zip file for above: https://drive.google.com/drive/folders/13aO8qYbikHs97q6CuBdtw-bzFVAwoVaf?usp=sharing

## 4. Steps to execute tests from command line

1. Official NUnit3 console installers are here: https://github.com/nunit/nunit-console/releases
2. Download NUnit.Console-*.msi package and install
3. Add to system PATH variable this: C:\Program Files (x86)\NUnit.org\nunit-console
4. Open command line
5. Type: nunit3-console APIFramework.dll

