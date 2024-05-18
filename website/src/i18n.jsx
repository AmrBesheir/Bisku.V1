import i18n from "i18next";
import { initReactI18next } from "react-i18next";
import languageDetector from "i18next-browser-languagedetector";

i18n
  .use(languageDetector)
  .use(initReactI18next)
  .init({
    debug: true,
    lng: "en",
    fallbackLng: "en",
    resources: {
      en: {
        translation: {
          greeting: "Hello There !",
          homePageTitle: "Home",
          ourshopstitle: "Our Shops",
          Categories: "Categories",
          Sponsored: "Sponsored",
          LastestProducts: "Lastest Products",
        },
      },
      ar: {
        translation: {
          greeting: "مرحبا بك",
          homePageTitle: "الرئيسية",
          ourshopstitle: "محلاتنا",
          Categories: "فئات",
          Sponsored: "ممؤل",
          LastestProducts: "أحدث المنتجات",
        },
      },
    },
  });

export default i18n;
