/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    const myArr = s.trim().split(" ");
    return myArr[myArr.length - 1].length;
};
