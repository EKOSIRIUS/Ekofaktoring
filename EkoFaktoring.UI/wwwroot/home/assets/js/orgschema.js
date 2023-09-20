let chart = new OrgChart(document.getElementById("tree"), {
   mouseScrool: OrgChart.action.none,
  enableSearch: false,
  template: "ula",
  nodeBinding: {
    field_0: "name",
  },
  tags: {
    "subLevels0": {
        subLevels: 0
    },
    "subLevels1": {
        subLevels: 1
    },
    "subLevels2": {
        subLevels: 2
    },
    "subLevels3": {
        subLevels: 3
    }
},
  nodes: [
    { id: 1, name: "Yönetim" },
    { id: 2, pid: 1, name: "Kredi Komitesi" },
    { id: 3, pid: 1, name: "Genel Müdür" },
    { id: 4, pid: 3, name: "Uyum görevlisi", tags: ['partner'] },
    { id: 5, pid: 1, name: "İç Denetim"},
    { id: 6, pid: 3, name: "Satış ve Pazarlamadan Sorumlu GMY", tags: ["subLevels0"] },
    { id: 7, pid: 3, name: "Subelerden Sorumlu GMY", tags: ["subLevels0"] },
    { id: 8, pid: 3, name: "Kredilerden Sorumlu GMY", tags: ["subLevels0"] },
    { id: 9, pid: 3, name: "Mali işlerden Sorumlu GMY", tags: ["subLevels0"] },
    { id: 10, pid: 6, name: "Genel Müdürlük Satış ve Pazarlama", tags: ["subLevels1"] },
    { id: 11, pid: 7, name: "Şubeler", tags: ["subLevels1"] },
    { id: 12, pid: 8, name: "Hukuk", tags: ["subLevels1"] },
    { id: 13, pid: 8, name: "Mali Tahlil", tags: ["subLevels2"] },
    { id: 14, pid: 8, name: "İstihbarat", tags: ["subLevels1"] },
    { id: 15, pid: 9, name: "Bilgi İşlem", tags: ["subLevels1"] },
    { id: 16, pid: 9, name: "Muhasebe", tags: ["subLevels3"] },
    { id: 17, pid: 9, name: "Finansman", tags: ["subLevels1"] },
    { id: 18, pid: 9, name: "Operasyon", tags: ["subLevels3"] },
    { id: 19, pid: 9, name: "İnsan Kaynakları", tags: ["subLevels1"] },
    { id: 20, pid: 19, name: "İdari İşler", tags: ["subLevels2"] }
  ],
  slinks: [
    {from: 2, to: 3, template: 'blue' },
]   

});

// OrgChart.templates.ula = Object.assign({}, OrgChart.templates.ana);
OrgChart.templates.ula.size = [250, 70];
OrgChart.templates.ula.defs = "";
OrgChart.templates.ula.field_0 = '<text data-width="230" data-text-overflow="multiline" style="font-size: 20px;" fill="#00000" x="125" y="30" text-anchor="middle">{val}</text>';
