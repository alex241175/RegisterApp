window.clipboardCopy = {
    copyText: function(text) {
       
        /* write to the clipboard now */
        navigator.clipboard.writeText(text).then(function () {
            alert("Copied to clipboard!");
        })
        .catch(function (error) {
            alert(error);
        });
             
    }
};


window.reload = function(){
    location.reload()
}

window.saveAsExcel = function (fileName, byteBase64) {
    var link = this.document.createElement('a');
    link.download = fileName;
    link.href ="data:application/vnd.ms-excel;" + byteBase64;
    this.document.body.appendChild(link);
    link.click();
    this.document.body.removeChild(link);
}

window.saveAsCsv = function (fileName, content) {
    var link = this.document.createElement('a');
    link.download = fileName;
    link.href = "data:text/csv;charset=utf-8," + encodeURI(content);
    this.document.body.appendChild(link);
    link.click();
    this.document.body.removeChild(link);
}

window.pivot = function(){
    $("#output").pivotUI(
        [
            {color: "blue", shape: "circle"},
            {color: "red", shape: "triangle"}
        ],
        {
            rows: ["color"],
            cols: ["shape"]
        }
    );
}