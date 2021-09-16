$(document).ready(function () {


    const langCoockiName = 'lang';

    var coockeis = document.cookie.split('; ');
    var filterCoockeis = coockeis.filter(x => x.split('=')[0] == langCoockiName);

    if (filterCoockeis.length > 0) {
        var currentCookieLang = filterCoockeis[0].split('=')[1];
        $('.language').val(currentCookieLang);
    }

    $('.language').change(function () {
        var newlang = $('.language').val();
        document.cookie = langCoockiName + "=" + newlang;
        location.reload();

    });


})