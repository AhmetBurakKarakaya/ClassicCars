
var videoGallery = new Vue({
    el: "#videoGallery",
    data: {
        videoGallery: [],
        videoGallery2: []
    },
    mounted: function () {
        this.getVideoGallery();
        this.getVideoGallery2();
    },
    methods: {
        getVideoGallery: function () {
            var vm = this;
            $.ajax({ url: "/VideoGallery/GetVideoGallery", method: "POST" })
                .done(function (data) {
                    vm.videoGallery = data.data;
                });
        },
        getVideoGallery2: function () {
            var vm = this;
            $.ajax({ url: "/VideoGallery/GetVideoGallery2", method: "POST" })
                .done(function (data) {
                    vm.videoGallery2 = data.data;
                });
        }
    }

})
