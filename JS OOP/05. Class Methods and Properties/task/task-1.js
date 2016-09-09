'use strict';
class listNode {
    constructor(value) {
        this._value = value;
        this._next = {};
    }
}

class LinkedList {
    constructor() {
        this._head = null;
        this._length = 0;
    }

    get first() {
        return this._head._value;
    }

    get last() {
        let current = this._head,
            index = 0;
        while (++index < this._length) {
            current = current.next;
        }
        if (current.next === undefined) {
            return current._value;
        } else {
            return null;
        }
    }

    get length() {
        return this._length;
    }

    *
    [Symbol.iterator]() {
        let current = this._head,
            index = 0,
            output = [];
        while (++index <= this._length) {
            output.push(current._value);
            current = current.next;
        }
        yield* output;
    }

    append(...values) {
        values.map((value) => {
            let node = new listNode(value),
                current;

            if (this._head === null) {
                this._head = node;
            } else {
                current = this._head;
                while (current.next) {
                    current = current.next;
                }
                current.next = node;
            }
            this._length++;
        });
        return this;
    }

    at(...index) {
        let current = this._head,
            currentIndex = 0,
            previous;
        if (index[0] === 0) {
            previous = this._head;
        }
        while (currentIndex++ <= index[0]) {
            previous = current;
            current = current.next;
        }
        if (index.length > 1) {
            previous._value = index[1];
        }

        return previous._value;
    }

    insert(index, ...values) {
        let current = this._head,
            currentIndex = 0,
            detachedHead;
        if (index === 0) {
            this.prepend(...values);
        } else {
            while (++currentIndex < index) {
                current = current.next;
            }

            detachedHead = current.next;
            current.next = null;
            this.append(...values);
            current = this._head;

            while (current.next) {
                current = current.next;
            }
            if (current.next === undefined) {

                current.next = detachedHead;
            }
        }

        return this;
    }

    prepend(...values) {
        let previousHead = this._head,
            previousLength = this._length;
        this._head = null;
        this._length = 0;
        this.append(...values);
        let current = this._head,
            index = 0;
        while (++index < this._length) {
            current = current.next;
        }
        if (current.next === undefined) {
            current.next = previousHead;
        } else {
            current = null;
        }
        this._length += previousLength;
        return this;
    }

    removeAt(index) {
        if (index > -1 && index < this._length) {
            let current = this._head,
                currentIndex = 0,
                previous;
            if (index === 0) {
                this._head = current.next;
                this._length--;
                return current._value;
            } else {
                while (currentIndex < index) {
                    previous = current;
                    current = current.next;
                    currentIndex++;
                }

                previous.next = current.next;
                this._length--;
                return current._value;
            }
        } else {
            return null;
        }
    }

    toArray() {
        let array = [];
        for (let item of this) {
            array.push(item);
        }
        return array;
    }

    toString() {
        return this.toArray().join(' -> ');
    }
}

module.exports = LinkedList;
