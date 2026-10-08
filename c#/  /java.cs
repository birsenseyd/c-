$(document).ready(function())
{
    //herhangi bir sekme butonuna tıklandığında...
    $('.tab-btn').click(function())
    {
        //1.Tıklanan butonun hangi içeriği hedeflediğini data-target özelliğinden al.
        var targetPanel = $(this).data('target');

        //Eğer tıklanan buton zaten aktifse, hiçbir şey yapma (gereksiz animasyonu önler.)
        if($(this).hasClass('active')) 
        {
            return;
        }

        //2.Butonların Stillerini Güncelle.
        $('.tab-btn').removeClass('active'); //tüm butonlardan aktifliği kaldır.
        $(this).addClass('active'); //Sadece tıklanan butona aktiflik ver ($(this) kavramı
        
        //3.İçerik Panellerini Değiştir.
        //Önce açık olan paneli yavaşça gizle
        $('.panel:visible').fadeOut(200, function())
        {
            //Gizleme işlemi bittikten sonra hedef paneli yavaşça göster
            $(targetPanel).fadeIn(200);
        };
    };
};

$(document).ready(function())
{
    //Sepetin toplam tutarını hafızada tutacağımız değişken
    let totalAmount = 0;

    //Toplam tutarı ekrana yazdıran ve ufak bir efekt veren yardımcı fonksiyon
    function updateDisplayTotal()
    {
        $('#total-price).text(totalAmount);
        
        //fiyat her güncellendiğinde dikkat çekmesi için yanıp sönme efekti 
        $('#total-price').fadeOut(100).fadeIn(100);
    }

    //1.Ürün Sepete ekleme 
    $('.add-to-cart').click(function())
    {
        //tıklanan butonun içindeki gizli (data) verileri al
        let itemName = $(this).data('name');
        let itemPrice = parseInt($(this).data('price')); //hesaplama yapacağımız için sayıya (integer) çeviriyoruz.

        //Kontrol : bu ürün sepette zaten var mı?
        //JQuery'nin güçlü seçicilerini kullanarak sepetin içinde aynı 'data-name'e sahip bir 'li' arıyoruz.
        let existingItem = $/('cart-items').find('li[data-name = "" + itemName + ""]');

        if (existingItem.Length > 0)
        {
            //ÜRÜN ZATEN VARSA : Yeni satır ekleme, sadece içindeki adedi (.qty) bul ve 1 arttır.
            let qtySpan = existingItem.find(".qty");
            let currentQty = parseInt(qtySpan.text());
            qtySpan.text(currentQty + 1);
        }

        else 
        {
            //ÜRÜN YOKSA: Sepete yeni bir <li> elementi olarak ekle
            //İleride silebilmek için fiyat ve isim verilerini bu li'ye de yapıştırıyoruz.
            let newItemHTML = 
                 <li data-name = "${itemName}" data-price = "${itemPrice}">
                     <span> ${itemName} (x<span class = "qty" > 1 /span>) </span>
                    <button class = "remove-item" > Sil </button>
                 </li>
            ;


             let newItem = $(newItemHTML).hide();  //önce gizli oluştur.
             $('#cart-items').append(newItem);
             newItem.slideDown(200); //sonra kayarak göster.
        }
        //sepet toplamını arttır ve ekrana yansıt
        totalAmount += itemPrice;
        updateDisplayTotal();
    });

    //2.sepetten ürün silme (event delegation)
    $('#cart-items').on('click', 'remove-item', function())
    {
        //.closest() metodu: tıklanan butonun en yakınındaki üst öğeyi (li elementini bulur.)
        let listItem = $(this).closest ('li');

        //silinen ürünün fiyatını ve o anki adedini bul.
        let itemPrice = parseInt(listItem.data('price'));
        let itemQty = parseInt(listItem.find('qty').text());

        //toplam tutardan (fiyat * adet ) kadar düş
        let deductAmount = itemPrice * itemQty;
        totalAmount -= deductAmount;
        updateDisplayTotal();

        //Ürünü sepetten animasyonlu bir şekilde uçur
        listItem.slideUp(200, function())
        {
            $(this).remove(); //Animasyon bitince HTML'den tamamen kazı
        });
    });
});

$(document).ready(function())
{
    //oyun değişkenleri 
    let score = 0;
    let timeLeft = 10; 
    let gameInterval;
    letmoveInterval;
    let isPlaying = false;

    //hedefin (emojinin) boyutları ve oyun alanının boyutları
    //hedefin kutu dışına taşmaması için bu ölçülere ihtiyacımız var.
    const boardWidth = $('#game-board').width();
    const boardHeight = $('game-board').height();
    const targetSize = 50; //ortalama emoji font boyutu

    //1.Hedefi rastgele bir yere taşıyan fonksiyon
    function moveTarget()
    {
        //0 ile (Maksimum Genişlik - Hedef genişliği) arasında rastgele bir sayı
        let randomX = Math.floor(Math.random() * (boardWidth - targetSize));
        let randomY = Math.floor(Math.random() * (boardHeight - targetSize));

        //Jquery ile CSS koordinatlarını anında değiştiriyoruz.
        $('target').css 
        {
            'left' : randomX + 'px',
            'top' : randomY + 'px'
        }
    }); 

    //2.Oyunu başlatma fonksiyonu 
    function startGame()
    {
        //değişkenleri ve ekranı sıfırla 
        isPlaying = true;

        $('#score').text(score);
        $('#timer').text(timeLeft);
        $('#game-over').hide();
        $('#initial-start-btn').hide();
        $('#target').show();
        
        //hedefi hemen ilk rastgele noktaya at
        moveTarget();

        //her 1 saniyede bir (1000ms) süreyi azalt
        gameInterval = setInvertal(function())
        {
            timeLeft--;
            $('#timer').text(timeLeft);

            if(timeLeft <= 0)
            {
                endgame(); //süre bittiyse oyunu bitir
            }
        } , 1000);

    //Her 800 milisaniyede bir hedefi zorla başka yere kaçır (Zorluk ayarı burasıdır)
        moveInvertal  = setInvertal(moveTarget, 800);
    }
    
    //3.Oyunu bitirme fonksiyonu
    function endgame()
    {
        isPlaying = false;
        clearInterval(gameInterval); //Zamanlayıcıyı durdur!
        clearInterval(moveInvertal); 

        $('#target').hide();
        $('#final-score').text(score);
        $('#game-over').fadeIn(); //Bitiş ekranını şık bir şekilde getir.
    }

    //4.Hedefe tıklama (vurma) olayı
    $('#target').on('mousedown', function())
    {
        if (!isPlaying) return; //oyun bitmişse puan alma
        
        score += 10; //her vuruş 10 puan 
        $('#score').text(score);

        //vurulunca hedefi hemen başka yere kaçır (zorlaştırmak için)
        moveTarget();

        //vurulduğunda skorun yanıp sönmesi gibi ufak bir efekt
        $('#score').fadeOut(50).fadeIn(50);
    });

    //Buton dinleyecileri
    $('#initial-start-btn , #start-btn').click(function()
    {
        startGame();
    });
});

