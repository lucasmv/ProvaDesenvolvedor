var id = 0;
var nome = "";
var quantidade = 0;

function ListarProdutos() {

    try {
        $.ajax({
            type: 'GET',
            url: '/Produto/GetListaListaDeProdutos',
            dataType: 'html',
            cache: false,
            async: true,
            success: function (data) {
                $('#modal-produtos .modal-body').html(data);
                $("#modal-produtos").modal();
            }
        });
    } catch (e) {
        alert(e.message);
    }
}

function AdicionaProduto(button) {
    try {
        var tr = $(button).closest("tr");

        id = $(tr).find(".produto-id").val();
        nome = $(tr).find(".produto-nome").text();

        $("#modal-produtos").modal("hide");

        $("#nome-produto-adicionar").text(nome);
        $("#modal-produto-carrinho").modal();

    } catch (e) {
        alert(e.message);
    }
};

function AdicionarProduto() {

    quantidade = document.getElementById("quantidade").value;

    $("#modal-produtos").modal("hide");


    $.ajax({
        url: '/Carrinho/AdicionaProduto',
        dataType: "json",
        type: "POST",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify({ produto: { Id: id, Quantidade: quantidade } }),
        async: true,
        processData: false,
        cache: false,
        success: function (data) {
            location.reload();
        },
        error: function (xhr) {
            alert('error');
        }
    })
}

function ZerarCarrinho() {
    if (confirm("Deseja realmento zerar o carrinho?"))
        window.location.href = "/Carrinho/ZerarCarrinho/";
    else
        return false;
}