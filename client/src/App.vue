<template>
  <div>
    <NavigationBar />
    <div class="main-content">
      <Introduction />
      <HelloWorld id="about" msg="Hunter to Your Vue.js App" />
      <HelloWorld id="skills" msg="Hunter to Your Vue.js App" />
      <HelloWorld id="work-xp" msg="Hunter to Your Vue.js App" />
      <HelloWorld id="projects" msg="Hunter to Your Vue.js App" />
      <HelloWorld id="contact" msg="Hunter to Your Vue.js App" />
    </div>
  </div>
</template>

<script>
import HelloWorld from "./components/HelloWorld.vue";
import Introduction from "./components/Introduction.vue";
import NavigationBar from "./components/NavigationBar.vue";

export default {
  name: "App",
  components: {
    HelloWorld,
    NavigationBar,
    Introduction
  }
};
</script>

<style lang="scss">
@import "@/assets/default.scss";
@import "@/assets/buttons.scss";

.main-content {
  padding: 10rem 30%;
}
</style>
