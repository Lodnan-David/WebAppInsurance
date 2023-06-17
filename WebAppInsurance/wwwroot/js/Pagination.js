
    var rows = document.querySelectorAll(".custom-table tbody tr");
    var previousButton = document.getElementById("previousButton");
    var nextButton = document.getElementById("nextButton");
    var currentPage = 1;
    var recordsPerPage = 5; // Počet záznamů na stránku
    var totalPages = Math.ceil(rows.length / recordsPerPage);

    // Přidání třídy "record" ke všem řádkům tabulky
    rows.forEach(function (row) {
        row.classList.add("record");
    });

    // Funkce pro zobrazení záznamů na aktuální stránce
    function showRecords() {
        // Skrytí všech řádků
        rows.forEach(function (row) {
            row.style.display = "none";
        });

        // Výpočet indexů počátečního a koncového záznamu na aktuální stránce
        var startIndex = (currentPage - 1) * recordsPerPage;
        var endIndex = Math.min(startIndex + recordsPerPage - 1, rows.length - 1);

        // Zobrazení odpovídajících řádků na aktuální stránce
        for (var i = startIndex; i <= endIndex; i++) {
            rows[i].style.display = "table-row";
        }

        // Aktualizace stavu tlačítek navigace
        previousButton.disabled = currentPage === 1;
        nextButton.disabled = currentPage === totalPages;

        // Posunutí scrollu na začátek tabulky
        document.querySelector(".custom-table").scrollTop = 0;
    }

    // Přiřazení akce k tlačítku "Předchozí"
    previousButton.addEventListener("click", function () {
        if (currentPage > 1) {
            currentPage--;
            showRecords();
        }
    });

    // Přiřazení akce k tlačítku "Další"
    nextButton.addEventListener("click", function () {
        if (currentPage < totalPages) {
            currentPage++;
            showRecords();
        }
    });

    // Zobrazení záznamů na první stránce při načtení stránky
    showRecords();
