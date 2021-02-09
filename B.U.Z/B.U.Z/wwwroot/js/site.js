// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



var connection = new signalR.HubConnectionBuilder().withUrl("/notHub").build();
connection.on("prijemPoruke", function (message) {

    //radi
    //var td = document.createElement("li");
    //td.textContent = message;
    //document.getElementById("tabela").appendChild(td);

    var tr = document.createElement("tr");
    var tdRb = document.createElement("td");
    var tdSad = document.createElement("td");
    tdSad.textContent = message;
    var brojObavijesti = parseInt(document.getElementById("notStomatolog").innerHTML);
    document.getElementById("notStomatolog").innerHTML = brojObavijesti + 1;
    document.getElementById("tabelaNeprocitane").appendChild(tr).appendChild(tdRb);
    document.getElementById("tabelaNeprocitane").appendChild(tr).appendChild(tdSad);
   
    document.getElementById("vijest").innerHTML = "";
    //brojObavijesti++;


    //var tabela = document.getElementById("tabela");
    //var red = tabela.insertRow(0);
    //var cell1 = row.insertCell(0);
    //var cell2 = row.insrtCell(1);
    //cell1.innerHTML = "nova obavijest";
    //cell2.innerHTML = message;
});
connection.start().then(function () {
    console.info("started signalR hub");

}).catch(function (err) {
    return console.error(err.toString());
});