function xyPosistion(id) {

    var element = document.getElementById(id);

    var box = element.getBoundingClientRect();

    return [box.x, box.y, box.width, box.height]
}

function setNodePosistion(id, x, y) {
    var element = document.getElementById(id);

    element.style.position = "absolute";
    element.style.left = x;
    element.style.top = y;

}

function setConnectorPosistion(id, x, y, w, h) {
    var element = document.getElementById(id);

    element.style.position = "absolute";
    element.style.left = x;
    element.style.top = y;
    element.style.width = w;
    element.style.height = h
}