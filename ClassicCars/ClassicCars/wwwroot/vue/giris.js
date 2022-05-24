var girisCtrl = new Vue({
    el: "#girisCtrl",
    data: {
        giris: {
            Email: "ahmet.karakaya99@erzurum.edu.tr",
            Parola : "123456"
        }
    },
    methods: {
        girisSorgula: function () {
            var vm = this;
            axios.post("/api/giris", vm.giris)
                .then(function (response) {
                    console.log(vm.giris.Email);
                    alert(response.data.message);
                    //document.getElementById("divSonuc").innerHTML = response.data.message;
                    if (response.data.result) { window.location.href = response.data.url; }

                })
                .catch(function (error) {
                    //document.getElementById("divSonuc").innerHTML = error.data.message;
                    alert(error.data.message);
                })
        },
        oturumuKapat: function () {
            axios.post("/Giris/OturumuKapat")
                .then(function (response) {
                    alert("Oturum Kapatılıyor...");
                })
        }
    }

})
