import unittest
import time
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class Homework(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_SearchForTelerikAcademy(self):
        RunBrowserToUrl("chrome","www.google.com")
        wait(TA.googleSearchBox, 30)
        click(TA.googleSearchBox)
        type(TA.googleSearchBox,"Telerik Academy")
        type(Key.ENTER)
        wait(TA.topSearchResult)

    def test_002_DragAndDropTest(self):
        RunBrowserToUrl("chrome","http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html")
        wait(Countries.norway)
        dragDrop(Capitals.oslo,Countries.norway)
        dragDrop(Capitals.madrid,Countries.spain)
        dragDrop(Capitals.rome,Countries.italy)
        dragDrop(Capitals.copenhagen,Countries.denmark)
        dragDrop(Capitals.washington,Countries.unitedStates)
        dragDrop(Capitals.stockholm,Countries.sweden)
        dragDrop(Capitals.seoul,Countries.southKorea)
        wait(CountryCapitalMatches.italy)
        wait(CountryCapitalMatches.spain)
        wait(CountryCapitalMatches.norway)
        wait(CountryCapitalMatches.denmark)
        wait(CountryCapitalMatches.sweden)
        wait(CountryCapitalMatches.unitedStates)
        wait(CountryCapitalMatches.spain)
        wait(CountryCapitalMatches.southKorea)

    def test_003_MinimizeWindows(self):
        type("d",KEY_WIN); sleep(1)
        for i in range(0,3):
            type("r", KEY_WIN); sleep(1)
            type("chrome")
            type(Key.ENTER)

        while(exists(TA.minimizeWindow)):
            click(TA.minimizeWindow)

    def test_004_SendSkypeMessage(self):
        RunApplication("skype")
        wait(Skype.useAnotherAccount,10)
        click(Skype.useAnotherAccount)
        wait(Skype.userName,10)
        click(Skype.userName)
        type("username")
        click(Skype.password)
        type("password")
        click(Skype.signInButton)
        wait(Skype.contacts,10)
        click(Skype.contactSearch)
        type("contact")
        type(Key.ENTER)
        sleep(1)
        type("New auto message")
        type(Key.ENTER)

    def test_005_CalculatorAdd(self):
        RunApplication("calc")
        wait(Calculator.title)
        addResult = Calculate(Key.NUM2+Key.NUM2,Key.NUM2,Key.ADD)
        self.assertEqual(addResult,"24")
        closeApp("calc")

    def test_006_CalculatorSubstract(self):
        RunApplication("calc")
        wait(Calculator.title)
        substractResult = Calculate(Key.NUM2+Key.NUM2,Key.NUM2,Key.MINUS)
        self.assertEqual(substractResult,"20")
        closeApp("calc")

    def test_007_CalculatorDivide(self):
        RunApplication("calc")
        wait(Calculator.title)
        divideResult = Calculate(Key.NUM2+Key.NUM2,Key.NUM2,Key.DIVIDE)
        self.assertEqual(divideResult,"11")
        closeApp("calc")

    def test_008_CalculatorDivideByZero(self):
        RunApplication("calc")
        wait(Calculator.title)
        divideResult = Calculate(Key.NUM2+Key.NUM2,Key.NUM0,Key.DIVIDE)
        self.assertEqual(divideResult,"Cannotdividebyzero")
        closeApp("calc")

    def test_009_CalculatorMultiply(self):
        RunApplication("calc")
        wait(Calculator.title)
        multiplyResult = Calculate(Key.NUM2+Key.NUM2,Key.NUM2,Key.MULTIPLY)
        self.assertEqual(multiplyResult,"44")
        closeApp("calc")

    def test_010_SearchForTAImage(self):
        RunBrowserToUrl("chrome","www.google.bg")
        wait(TA.googleImagesTab,5)
        click(TA.googleImagesTab)
        wait(TA.googleImageSearch,5)
        click(TA.googleImageSearch)
        type("telerik academy")
        type(Key.ENTER)
        wait(TA.searchTargetImage,10)
        rightClick(TA.searchTargetImage)
        click(TA.contextMenuCopyLink)
        rightClick(TA.addressBar)
        click(TA.contextMenuPasteAndGo)


if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(Homework)
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Homework Report' )
    runner.run(suite)
    outfile.close()



