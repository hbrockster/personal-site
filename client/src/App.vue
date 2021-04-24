<template>
  <div id="app">
    <NavigationBar />
    <Introduction />
  </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import NavigationBar from '@/components/NavigationBar.vue';
import Introduction from '@/components/Introduction.vue';

@Component({ components: { NavigationBar, Introduction }})
export default class App extends Vue {
}
</script>

<style>
#app {
    font-family: Space Mono, Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    margin-top: 60px;
}
* {
    background: #272727;
    color: #67ff88;
    font-size: 16px;
}
</style>
