<script>
export default {
  props: {
    modelValue: String,
    data: Date,
  },
  emits: ['update:modelValue', 'update:data']
}
</script>

<template>
  <input
    :value="modelValue"
    class="titulo"
    placeholder="Titulo"
    @input="$emit('update:modelValue', $event.target.value)"
  />

  <input
    :value="data"
    type="date"
    class="data"
    placeholder="--/--/----"
    @input="$emit('update:data', $event.target.value)"
  />
</template>

<style scoped>
/* ===== TÍTULO ===== */
.titulo {
  display: inline-block;
  vertical-align: middle;
  box-sizing: border-box;
  width: calc(100% - 196px);
  margin: 0 0 16px;
  padding: 8px 0 10px;
  font-family: inherit;
  font-size: 1.9rem;
  font-weight: 700;
  letter-spacing: -0.02em;
  color: var(--texto, #1f2d1f);
  background: transparent;
  border: none;
  border-bottom: 2px solid var(--borda, #cfe5c8);
  border-radius: 0;
  outline: none;
  transition: border-color 0.2s, color 0.25s;
}

.titulo::placeholder {
  color: var(--placeholder, #a9b8a5);
  font-weight: 600;
}

.titulo:focus {
  border-bottom-color: var(--destaque, #8fc47f);
}

/* ===== DATA ===== */
.data {
  display: inline-block;
  vertical-align: middle;
  box-sizing: border-box;
  width: 170px;
  margin: 0 0 16px 16px;
  padding: 9px 14px;
  font-family: inherit;
  font-size: 0.9rem;
  font-weight: 500;
  color: var(--texto-suave, #5b6b5b);
  background: transparent;
  border: 1px solid var(--borda, #cfe5c8);
  border-radius: 999px;
  outline: none;
  cursor: pointer;
  transition: border-color 0.2s, box-shadow 0.2s, color 0.25s;
}

.data:hover {
  border-color: var(--destaque, #8fc47f);
}

.data:focus {
  border-color: var(--destaque, #8fc47f);
  box-shadow: 0 0 0 3px rgba(143, 196, 127, 0.25);
}

.data::-webkit-calendar-picker-indicator {
  cursor: pointer;
  opacity: 0.6;
}

.data::-webkit-calendar-picker-indicator:hover {
  opacity: 1;
}

/* ===== TELA ESTREITA: um embaixo do outro ===== */
@media (max-width: 560px) {
  .titulo,
  .data {
    display: block;
    width: 100%;
    margin-left: 0;
  }
}
</style>
