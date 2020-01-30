var dragged;
function drag(e) {
    dragged = e.target;
}
function allowDrop(e) {
    e.preventDefault();
}
function drop(e) {
    e.preventDefault();

    let parent;
    if (e.currentTarget) {
        parent = e.currentTarget
    } else {
        parent = e.path.filter((i) => {
            if (i.classList) {
                return i.classList.contains('kanban-list');
            }
        })[0];
    }
    parent.appendChild(dragged);
}