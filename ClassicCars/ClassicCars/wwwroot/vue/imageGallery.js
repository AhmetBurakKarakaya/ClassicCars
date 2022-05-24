
var v = new Vue({
    el: "#imageGallery",
    data: {
        imageGallery: null
    },
    mounted: function () {
        this.getImageGallery();
    },
    methods: {
        getImageGallery: function () {
            var vm = this;
            $.ajax({ url: "/ImageGallery/GetImageGallery", method: "POST" })
                .done(function (data) {
                    vm.imageGallery = data.data;
                });
        }
    }

})