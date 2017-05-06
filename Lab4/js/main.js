/**
 * Created by barto on 03.05.17.
 */

var products = [{
    'id': '0', 'title': 'Koszyk jabłek', 'price': 15, 'pictureName': 'apple-bucket'
}, {
    'id': '1', 'title': 'Cydr jabłkowy (0.5l)', 'price': 20, 'pictureName': 'cider'
}, {
    'id': '2', 'title': 'Sukienka', 'price': 300, 'pictureName': 'dress'
}, {
    'id': '3', 'title': 'Kapelusz', 'price': 50, 'pictureName': 'hat'
}, {
    'id': '4', 'title': 'Smoczy asystent', 'price': 2500, 'pictureName': 'dragon'
}, {
    'id': '5', 'title': 'Papier listowy', 'price': 10, 'pictureName': 'scroll'
}];

var basket = [];

$(document).ready(function (e) {

    $('.nav-link').click(changeTab);

    $('.inline-nav-link').click(changeTab);

    $('#emptyBasket').click(emptyBasket);

    $('#confirmOrder').click(emptyBasket);

    $('#addNewProduct').click(addNewProduct);

});

function changeTab (e) {

    e.preventDefault();

    var href = $(this).attr('href');

    $('article').hide();
    $(href).show();

    $('.nav-link').removeClass('active');

    if ($(this).attr('class') == 'inline-nav-link') { //wiem ze to koszmarne obejscie problemu, ale nie wiedzialem jak zrobic to inaczej :/
        if (href == '#store') {
            $('#store_link').addClass('active');
        }
    }
    else {
        $(this).addClass('active');
    }

    if(href == '#store') {
        showProducts();
    }
    else if (href == '#cart') {
        showBasketContent();
    }

}

function showProducts() {
    $('[id^="product-"]').remove();

    $.each(products, (key, value) => {
        var product = $('#productTemplate').clone();
        product.attr('id', 'product-' + value.id);
        product.css('display', '');
        product.find('.product-photo').attr('src', 'img/products/' + value.pictureName + '.png');
        product.find('.product-title').text(value.title);
        product.find('.product-price').text(value.price + ' PLN');
        product.find('.product-toBasket-button').on('click', (e) => {
            e.preventDefault();
            basket.push({'title': value.title, 'price': value.price});
        });
        $('#productTemplate').after(product);
    });
}

function showBasketContent() {
    if(basket.length != 0) {
        $('#emptyBasketNotification').hide();

        $('[id^="basketEntry-"]').remove();

        var i = 0;
        var total = 0;

        $.each(basket, (key, value) => {
            var basketEntry = $('#basketContentHeader').clone();
            basketEntry.attr('id', 'basketEntry-' + i);
            i++;
            basketEntry.find('.basketEntry-title').text(value.title);
            basketEntry.find('.basketEntry-price').text(value.price);
            total += value.price;
            $('#basketContentHeader').after(basketEntry);
        });

        $('#totalPrice').text(total + ' PLN');

        $('#basketContent').show();
    }
}

function emptyBasket(e) {
    e.preventDefault();

    basket = [];
    $('#emptyBasketNotification').show();
    $('#basketContent').hide();
}

function addNewProduct(e) {
    e.preventDefault();

    var title = $('#newElementTitle').val();
    var price = isNaN(parseInt($('#newElementPrice').val())) ? 0 : parseInt($('#newElementPrice').val());
    var id = products.length;
    var pictureName = 'default';

    products.push({'id': id, 'title': title, 'price': price, 'pictureName': pictureName});
}
