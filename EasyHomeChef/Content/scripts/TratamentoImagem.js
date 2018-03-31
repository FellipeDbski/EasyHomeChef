$(document).ready(function () {
    $('#file').MultiFile({
        accept: 'gif|jpg|png',
        max: 3,
        STRING: {
            remove: 'Remover',
            denied: 'Tipo do arquivo inválido $ext!',
            duplicate: 'Esse arquivo já foi selecionado:\n$file!'
        }
    });
});