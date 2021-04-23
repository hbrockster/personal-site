module.exports = {
  root: true,

  env: {
    node: true
  },

  // extends: ["plugin:vue/vue3-essential", "eslint:recommended", "@vue/prettier"],

  parserOptions: {
    parser: '@typescript-eslint/parser'
  },

  // extends: [
  //   "plugin:vue/vue3-essential",
  //   "eslint:recommended",
  //   "@vue/prettier",
  //   "@vue/typescript"
  // ]
  rules: {
    "no-console": process.env.NODE_ENV === "production" ? "warn" : "off",
    "no-debugger": process.env.NODE_ENV === "production" ? "warn" : "off"
  },

  extends: [
    '@vue/typescript',
    'eslint:recommended',
    'plugin:vue/recommended',
    'plugin:vue/vue3-essential'
  ]
};
