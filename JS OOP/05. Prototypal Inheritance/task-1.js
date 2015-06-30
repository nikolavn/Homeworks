/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
    var domElement = (function() {
        var domElement = {
            init: function(type) {
                this.type = type;
                this.content = '';
                this.attributes = {};
                this.children = [];
                this.parent = null;

                return this;
            },
            appendChild: function(child) {
                this.children.push(child);

                if (typeof child !== 'string') {
                    child.parent = this;
                }
                return this;
            },
            addAttribute: function(name, value) {
                if (!isStringEmpty(name) && isValidAttributeName(name)) {
                    this.attributes[name] = value;
                    return this;
                } else {
                    throw new Error('Attribute name: ' + name + ' should contain only letters numbers and dashes.');
                }
            },
            removeAttribute: function(attribute) {
                if (this.attributes.hasOwnProperty(attribute)) {
                    delete this.attributes[attribute];
                    return this;
                } else {
                    throw new Error('No such attribute: ' + attribute);
                }
            },
            get innerHTML() {
                var innerHTML,
                    currentChild,
                    childrenContent = '';

                innerHTML += '<' + this.type + stringifyAttributes(this.attributes) + '>';

                if (this.children.length > 0) {

                    for (var i = 0; i < this.children.length; i += 1) {
                        currentChild = this.children[i];

                        if (typeof currentChild === 'string') {
                            childrenContent += currentChild;
                        } else {
                            childrenContent += currentChild.innerHTML;
                        }
                    }
                    innerHTML = '<' + this.type + stringifyAttributes(this.attributes) + '>' + childrenContent + '</' + this.type + '>';
                } else {
                    innerHTML = '<' + this.type + stringifyAttributes(this.attributes) + '>' + this.content + '</' + this.type + '>';
                }

                return innerHTML;
            }
        };

        Object.defineProperty(domElement, 'type', {
            get: function() {
                return this._type;
            },
            set: function(value) {
                if (!isStringEmpty(value) && isValidType(value)) {
                    this._type = value;
                } else {
                    throw new Error('Element type: ' + value + ' should contain only letters and numbers');
                }
            }
        });

        Object.defineProperty(domElement, 'content', {
            get: function() {
                return this._content;
            },
            set: function(value) {
                if (!this.hasChildren) {
                    this._content = value;
                }
            }
        });

        function isStringEmpty(input) {
            if (!input || 0 === input.length) {
                return true;
            }

            return false;
        }

        function isValidAttributeName(attributeName) {
            if (/^[A-Z0-9\-]+$/i.test(attributeName)) {
                return true;
            }

            return false;
        }

        function isValidType(elementType) {
            if (/^\d*[a-zA-Z][a-zA-Z\d]*$/g.test(elementType)) {
                return true;
            }

            return false;
        }

        function stringifyAttributes(attributes) {
            var keys = [],
                output = '',
                attrName, attrValue, i, len;

            for (attrName in attributes) {
                if (attributes.hasOwnProperty(attrName)) {
                    keys.push(attrName);
                }
            }

            keys.sort();

            len = keys.length;

            for (i = 0; i < len; i += 1) {
                attrName = keys[i];
                attrValue = attributes[attrName];
                output += ' ' + attrName + '=' + '"' + attrValue + '"';
            }

            return output;
        }

        return domElement;
    }());
    return domElement;
}

module.exports = solve;
