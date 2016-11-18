function successFunction(msg) {
    if (msg.substring(0, 4) == "Erro") {
        divalert(msg, 'alert-danger')
    } else {
        divalert('Operação realizada com sucesso.', 'alert-success');
    }
}

function errorFunction(msg) {
    divalert("Erro, Atualize a pagina e tente novamente!", 'alert-danger');
}

function fecharmodal() {
    $(".popup").bPopup().close();
    $('.b-modal').css('display', 'none');
}


function divalert(texto, tipo) {
    $('.rowerros').append('<div class="alert ' + tipo + ' col-sm-12 div-alert">'
                + '<label id="lbalert" class="lbalert">' + texto + '</label></div>');

    $('.div-alert:last').delay(6000).slideUp(400);
}

function limite(campo, caractres) {
    if ($(campo).val().length > caractres) {
        $(campo).val($(campo).val().substr(0, caractres));
        $.alert('O Campo não pode ter mais de ' + caractres + ' caracteres.');
    }
}

