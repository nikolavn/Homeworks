(function(){

	var browser = navigator.appName,
		addScroll = false,
		txt = "",
		popUpX = 0,
		popUpY = 0;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

document.onmousemove = mouseMove;
if (browser == "Netscape") {
    document.captureEvents(Event.MOUSEMOVE);
}

function mouseMove(evn) {
    if (browser == "Netscape") {
        popUpX = evn.pageX - 5;
        popUpY = evn.pageY;
    } else {
        popUpX = event.x - 5;
        popUpY = event.y;
    }
    if (browser == "Netscape") {
        if (document.layers.ToolTip.visibility == 'show') {
            popToolTip();
        }
    } else {
        if (document.all.ToolTip.style.visibility == 'visible') {
            popToolTip();
        }
    }
}

function popToolTip() {
    if (browser == "Netscape") {
        theLayer = eval('document.layers[\'ToolTip\']');
        if ((popUpX + 120) > window.innerWidth) {
            popUpX = window.innerWidth - 150;
        }
        theLayer.left = popUpX + 10;
        theLayer.top = popUpY + 15;
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'ToolTip\']');
        if (theLayer) {
            popUpX = event.x - 5;
            popUpY = event.y;
            if (addScroll) {
                popUpX = popUpX + document.body.scrollLeft;
                popUpY = popUpY + document.body.scrollTop;
            }
            if ((popUpX + 120) > document.body.clientWidth) {
                popUpX = popUpX - 150;
            }
            theLayer.style.pixelLeft = popUpX + 10;
            theLayer.style.pixelTop = popUpY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
}

function hideToolTip() {
    args = hideToolTip.arguments;
    if (browser == "Netscape") {
        document.layers.ToolTip.visibility = 'hide';
    } else {
        document.all.ToolTip.style.visibility = 'hidden';
    }
}

	function hideMenu(menuID) {
		if (browser == "Netscape") {
			document.layers.menuID.visibility = 'hide';
		} else {
			document.all.menuID.style.visibility = 'hidden';
		}
	}

	function showMenu(menuID) {
		if (browser == "Netscape") {
			theLayer = eval('document.layers[' + menuID + ']');
			theLayer.visibility = 'show';
		} else {
			theLayer = eval('document.all[' + menuID + ']');
			theLayer.style.visibility = 'visible';
		}
	}
 // fostata
})();