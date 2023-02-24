function RadioButtons(name) {

    var ele = document.getElementsByName(name);

    for (i = 0; i < ele.length; i++) {
        if (ele[i].checked)
            return ele[i].value +";";
    }
    return "none";
}

function CheckBoxs(name) {
    var checkboxes = document.getElementsByName(name);
    var result = "";

    for (var i = 0; i < checkboxes.length; i++) {
        if (checkboxes[i].checked) {
            result += checkboxes[i].value + ";";
        }
    }
    return result
}

function TextFeild(name) {
    var ans = document.getElementsByName(name)[0].value;
    return ans;
}