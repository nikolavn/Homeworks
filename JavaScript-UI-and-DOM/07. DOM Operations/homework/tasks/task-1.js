/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
    if (typeof(element)!=='string' && !(element instanceof HTMLElement)) {
      throw ('Unknown element');
    }
    
    if (!element) {
      throw ('element with this id doesn\'t exist');
    }
    
    if (!contents || contents.some(function(item){
      return (typeof(item)!=='string' && typeof(item)!=='number');
    })) {
      throw ('contents should be array of numbers and strings');
    }
    
    var currentElement = document.getElementById(element)||element,
        fragment = document.createDocumentFragment(),
        contentDiv = document.createElement('div'),
        currentContentDiv;
        
    while(currentElement.firstChild){
      currentElement.removeChild(currentElement.firstChild);
    }
    
    for (var index = 0; index < contents.length; index++) {
        currentContentDiv = contentDiv.cloneNode(true);
        currentContentDiv.innerHTML = contents[index];
        fragment.appendChild(currentContentDiv);    
    }
    
    currentElement.appendChild(fragment);
  };
};