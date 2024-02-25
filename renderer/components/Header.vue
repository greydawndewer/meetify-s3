<template>
  <header>
    <logo></logo> <!-- New logo component -->
    <h1>{{ title }}</h1>
    <nav>
      <ul>
        <li><a href="#">Home</a></li>
        <li><a href="#">About</a></li>
        <li><a href="#">Contact</a></li>
      </ul>
    </nav>
  </header>
</template>

<script>
import Logo from './Logo.vue'; // Import the Logo component

export default {
  components: {
    Logo // Register the Logo component
  },
  data() {
    return {
      title: 'My App'
    };
  }
};
</script>

<style scoped>
/* CSS styles for the header */
</style>