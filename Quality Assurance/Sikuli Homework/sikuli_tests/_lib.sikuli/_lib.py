from sikuli import *
import HTMLTestRunner
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _uimap import *

def RunBrowserToUrl(browser,toUrl):
    #TestAction("Start " +browser +" "+toUrl)
    sleep(0.5)
    type("d",KEY_WIN); sleep(1)
    type("r", KEY_WIN); sleep(1)
    type(browser+" "); sleep(1)
    type(toUrl); sleep(1)
    type(Key.ENTER)

def RunApplication(applicationName):
    sleep(0.5)
    type("d",KEY_WIN); sleep(1)
    type("r", KEY_WIN); sleep(1)
    type(applicationName);sleep(1)
    type(Key.ENTER)

def Calculate(param1, param2, operator):
    sleep(0.5)
    type(Key.ESC)
    type(param1 + operator + param2 + Key.ENTER)
    type("c",KeyModifier.CTRL)
    result = Env.getClipboard()
    return result
