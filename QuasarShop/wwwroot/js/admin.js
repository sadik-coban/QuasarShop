$(() => {
    $('.remove-btn').on('click', (evt) => {
        Swal.fire({
            icon: 'warning',
            title: 'UYARI!',
            html: 'Bu kayıt <b>TAMAMEN</b> silinecektir. Devam etmek istiyor musunuz?',
            confirmButtonText: '<i class="bi bi-trash"></i> SİL',
            showCancelButton: true,
            cancelButtonText: 'İPTAL'
        })
            .then((result) => {
                if (result.isConfirmed) {
                    window.location = $(evt.currentTarget).attr('href');
                }
            });;
        return false;
    });
})
