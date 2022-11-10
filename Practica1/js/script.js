btn_search.addEventListener("click", function () {

    let input_search = document.getElementById("input_search");
    let btn_search = document.getElementById("btn_search");
    let value;
    let isTrue = false;
    let list_div = document.getElementById("list_div");
    let a = document.createElement("a");
    value = input_search.value;
    value = value.trim();
    let list_items = document.getElementsByClassName("list_items");
    console.log(list_items);

    if (value.length != 0) {

        isTrue = checkStr(isTrue, list_items, value);

        if (!isTrue) {
            list_div.innerHTML += `<a href="#" class="list-group-item list-group-item-action list_items">${value}</a>`
            alert("succesfuly added")
        }
    }
    else {
        alert("empty value");
        return;
    }

});

function checkStr(isTrue, list_items, value) {

    for (const list_item of list_items) {

        if (list_item.innerText.toLowerCase() == value.toLowerCase()) {
            isTrue = true;
            alert("Already added");
            break;
        }
    }
    return isTrue;
};