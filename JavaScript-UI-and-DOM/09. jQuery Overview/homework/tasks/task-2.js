/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function(selector) {
    if (typeof(selector) !== 'string' && !(selector instanceof jQuery)) {
      throw ('unknown selector');
    }

    if (!selector) {
      throw ('selector does not exist');
    }

    if($(selector).length === 0){
      throw ('selector selects nothing');
    }

    var buttons = $('.button'),
    currentButton, len = buttons.length;
    buttons.text('hide');

   
      $('.button').on('click', function() {
        var $clickedButton = $(this),
          $nextContent = $clickedButton.next();

        while ($nextContent && !$nextContent.hasClass('content')) {
          $nextContent = $nextContent.next();
        }

        var displayStatus = $nextContent.css('display');

        if (displayStatus === ''||displayStatus === 'block'||displayStatus === 'inline-block') {
          $nextContent.css('display','none');
          $clickedButton.text('show');
        } else {
          $nextContent.css('display','');
          $clickedButton.text('hide');
        }

      });
    
  };
};

module.exports = solve;