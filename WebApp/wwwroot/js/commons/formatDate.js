function formatDateForInput(dateStr) {
    const parts = dateStr.trim().split(' ')[0].split('/'); // Lấy phần ngày: "22/10/2025"
    if (parts.length === 3) {
        const [dd, mm, yyyy] = parts;
        return `${yyyy}-${mm.padStart(2, '0')}-${dd.padStart(2, '0')}`;
    }
    return '';
}

function formatDateForInputISO(isoString) {
    if (!isoString) return '';

    const date = new Date(isoString);

    // Kiểm tra xem ngày có hợp lệ không
    if (isNaN(date.getTime())) return '';

    // Lấy ngày theo giờ địa phương (local date)
    const year = date.getFullYear();
    const month = String(date.getMonth() + 1).padStart(2, '0'); // tháng bắt đầu từ 0
    const day = String(date.getDate()).padStart(2, '0');

    return `${year}-${month}-${day}`;
}