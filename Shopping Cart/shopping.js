function NewItem(){
    //alert("button clicked");
    var unorderedList = document.getElementById("list1");
    var inputField = document.getElementById("input1");
    var item = inputField.value; //sets item as the value of input field
    //console.log(item);

    var listItem = document.createElement("li");
    listItem.appendChild(document.createTextNode(item));
    unorderedList.appendChild(listItem);

    var deleteButton = document.createElement('button');
    deleteButton.textContent = "DELETE";
    deleteButton.id = "DeleteButton";
    deleteButton.addEventListener('click', function() {
        unorderedList.removeChild(listItem); // Remove the list item
    });
    listItem.appendChild(deleteButton);


    
}


