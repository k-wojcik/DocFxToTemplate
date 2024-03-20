// @ts-check
// `@type` JSDoc annotations allow editor autocompletion and type checking
// (when paired with `@ts-check`).
// There are various equivalent ways to declare your Docusaurus config.
// See: https://docusaurus.io/docs/api/docusaurus-config

import {themes as prismThemes} from 'prism-react-renderer';

/** @type {import('@docusaurus/types').Config} */
const config = {
    title: 'DocFxToTemplate',
    tagline: '',
    favicon: 'img/favicon.ico',

    // Set the production url of your site here
    url: 'https:///k-wojcik.github.io',
    // Set the /<baseUrl>/ pathname under which your site is served
    // For GitHub pages deployment, it is often '/<projectName>/'
    baseUrl: '/DocFxToTemplate/',

    // GitHub pages deployment config.
    // If you aren't using GitHub pages, you don't need these.
    organizationName: 'k-wojcik', // Usually your GitHub org/user name.
    projectName: 'DocFxToTemplate', // Usually your repo name.

    onBrokenLinks: 'throw',
    onBrokenMarkdownLinks: 'warn',

    // Even if you don't use internationalization, you can use this field to set
    // useful metadata like html lang. For example, if your site is Chinese, you
    // may want to replace "en" with "zh-Hans".
    i18n: {
        defaultLocale: 'en',
        locales: ['en'],
    },

    presets: [
        [
            'classic',
            /** @type {import('@docusaurus/preset-classic').Options} */
            ({
                docs: {
                    sidebarPath: './sidebars.js',
                    // Please change this to your repo.
                    // Remove this to remove the "edit this page" links.
                    editUrl: 'https://github.com/k-wojcik/DocFxToTemplate/edit/master/docs/',
                    async sidebarItemsGenerator({defaultSidebarItemsGenerator, ...args}) {
                        filterSidebarItems(args);
                        return defaultSidebarItemsGenerator(args);
                    },
                },
                blog: false,
                theme: {
                    customCss: './src/css/custom.css',
                },
            }),
        ],
    ],

    markdown: {
    },

    themes: [
        [
            require.resolve("@easyops-cn/docusaurus-search-local"),
            /** @type {import("@easyops-cn/docusaurus-search-local").PluginOptions} */
            ({
                hashed: true,
            }),
        ],
    ],

    themeConfig:
    /** @type {import('@docusaurus/preset-classic').ThemeConfig} */
        ({
            // Replace with your project's social card
            navbar: {
                title: 'DocFxToTemplate',
                logo: {
                    alt: 'DocFxToTemplate',
                    src: 'img/logo.svg',
                },
                items: [
                    {
                        type: 'docSidebar',
                        sidebarId: 'docsSidebar',
                        position: 'left',
                        label: 'Docs',
                    },
                    {
                        type: 'docSidebar',
                        sidebarId: 'apiSidebar',
                        position: 'left',
                        label: 'API',
                    },
                    {
                        href: 'https://github.com/k-wojcik/DocFxToTemplate',
						className: 'header-github-link',
                        position: 'right',
                    },
                ],
            },
            footer: {
                style: 'dark',
                copyright: `Copyright © ${new Date().getFullYear()} DocFxToTemplate. Built with Docusaurus.`,
            },
            prism: {
                theme: prismThemes.github,
                darkTheme: prismThemes.dracula,
                additionalLanguages: ['csharp', 'bash', 'json'],
            },
        }),
};

function filterSidebarItems(args) {
    if (args.item.customProps != null
        && args.item.customProps.exclude != null
        && args.item.customProps.exclude.length > 0) {
        args.docs = args.docs.filter(x => !args.item.customProps.exclude.some(path => x.id.startsWith(path)));
    }
}

export default config;
