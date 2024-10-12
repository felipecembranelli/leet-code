function reverseString(str) {
    let reversed = ""
    for (let index = str.length - 1; index >= 0; index--) {

            reversed += str[index]; 
            
    }
}

//reverseString("yoyo master");

function reverseStringRecursive(str) {
    if (str === "") {
        return "";
      } else {
        return reverseStringRecursive(str.substr(1)) + str.charAt(0);
      }

}


console.log(reverseStringRecursive("yoyo master"));
