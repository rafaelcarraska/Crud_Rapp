
function Modal(result) {
    $('.rowerros .divalert:last').hide();
    switch (result) {
        case '1':
            divalert('(1) O assassino está incorreto.', 'alert-danger');
            break;
        case '2':
            divalert('(2) O local está incorreto.', 'alert-danger');
            break;
        case '3':
            divalert('(3) A arma está incorreta.', 'alert-danger');
            break;            
        case '0':
            $('#result').html('(0) Parabéns, você acertou.');
            $('#popup').bPopup({
                modalClose: false,
                positionStyle: 'fixed'
            });
            break; 
    }     
}

function Crime() {
    let suspeito = $('#cbsuspeitos option:selected').val();
    let arma = $('#cbarmas option:selected').val();
    let local = $('#cblocais option:selected').val();
    var url = "../Home/Caso";
    $.ajax({
        url: url,
        type: "POST",
        async: true,
        data: { suspeito: suspeito, arma: arma, local: local },
        success: function (jsn) {
            Modal(jsn);
        }
    });
}