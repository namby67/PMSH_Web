function showToast(title, message, isSuccess) {
    const toast = new bootstrap.Toast($('#nameToast')[0]);
    $('#toastTitle').text(title);
    $('#toastMessage').text(message);

    // Xóa hết các class màu trước
    $('#nameToast').removeClass('bg-success bg-danger bg-warning text-white');

    // Thêm class dựa vào title và isSuccess
    if (title === "Warning") {
        $('#nameToast').addClass('bg-warning text-dark'); // vàng, chữ màu tối
    } else {
        $('#nameToast').addClass(isSuccess ? 'bg-success text-white' : 'bg-danger text-white');
    }

    toast.show();
}